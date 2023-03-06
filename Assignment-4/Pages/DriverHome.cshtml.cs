using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Assignment_2___Online_Grocery_Membership_Prototype_Cardinal_.Pages;
using Assignment2;

public class DriverHomeModel : PageModel
{
    private readonly ILogger<DriverHomeModel> _logger;
    private readonly DBContext _context;

    public DriverHomeModel(DBContext context,ILogger<DriverHomeModel> logger)
    {
        _context=context;
        _logger = logger;
    }

    public void OnGet()
    {
    }
}