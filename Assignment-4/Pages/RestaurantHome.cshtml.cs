using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_2___Online_Grocery_Membership_Prototype_Cardinal_.Pages;
using Assignment2;

public class RestaurantHomeModel : PageModel
{
    private readonly ILogger<RestaurantHomeModel> _logger;
    private readonly DBContext _context;

    public RestaurantHomeModel(DBContext context,ILogger<RestaurantHomeModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
    }
}