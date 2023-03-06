using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_2___Online_Grocery_Membership_Prototype_Cardinal_.Pages;
using Assignment2;

public class ShopperHomeModel : PageModel
{
    private readonly ILogger<ShopperHomeModel> _logger;
    private readonly DBContext _context;
    [BindProperty]
    [Required]
    public int? RestaurantChoice {get; set;}
    [BindProperty]
    [Required]
    public int? MenuItemsChoice {get; set;}
    public List<SelectListItem>? RestaurantChoices {get; set;}
    public List<SelectListItem>? MenuItemsChoices {get; set;}

    public ShopperHomeModel(DBContext context,ILogger<ShopperHomeModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
        RestaurantChoices=_context.restaurants.Select(h => new SelectListItem{Value=h.RestaurantsID.ToString(),Text=h.Name}).ToList();
    }
    public void OnPost()
    {
    }
    public void OnPostMenuSelect()
    {
        _logger.LogInformation("OnPostMenuSelect() Called "+RestaurantChoice);
        Response.Redirect("./ShopperHome");
    }
    public void OnPostResturantSelect()
    {
        if(RestaurantChoice!=null){
            _logger.LogInformation("OnPostResturantSelect() Called "+RestaurantChoice);
            RestaurantChoices=_context.restaurants.Select(h => new SelectListItem{Value=h.RestaurantsID.ToString(),Text=h.Name}).ToList();
            MenuItemsChoices=_context.menuItems.Where(hh=>hh.RestaurantsID==RestaurantChoice).Select(hhh => new SelectListItem{Value=hhh.MenuItemsID.ToString(),Text=hhh.Name}).ToList();
        }
        else{
            _logger.LogInformation("OnPostResturantSelect() Called with no ID");
        }
    }
}