using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_2___Online_Grocery_Membership_Prototype_Cardinal_.Pages;
using Assignment2;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DBContext _context;
    public static int login=0;
    public static bool loginpass=false;
    [BindProperty]
    [Display(Name = "Email")]
    [StringLength(60,MinimumLength =3)]
    [Required]
    public string Email {get; set;} = string.Empty;
    [BindProperty]
    [Display(Name = "Password")]
    [StringLength(60,MinimumLength =3)]
    [DataType(DataType.Password)]
    [Required]
    public string Password {get; set;} = string.Empty;

    public IndexModel(DBContext context,ILogger<IndexModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
        login=0;
        loginpass=false;
    }
    
    public void OnPost()
    {
        _logger.LogInformation("OnPost() Called "+Email+" "+Password);
        var holder=_context.persons.FirstOrDefault(persons => persons.Email == Email);
        if(holder!=null&&holder.Password==Hash.hash256(Password,holder.PersonsID.ToString()))
        {
            login=holder.PersonsID;
            loginpass=true;
            var holder2=_context.drivers.FirstOrDefault(drivers => drivers.PersonsID == login);
            if(holder2!=null)
            {
                Response.Redirect("./DriverHome");
            }
            else
            {
                var holder3=_context.shoppers.FirstOrDefault(shoppers => shoppers.PersonsID == login);
                if(holder3!=null)
                {
                    Response.Redirect("./ShopperHome");
                }
            }
        }
    }
}
