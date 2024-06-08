using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Temple.Net.Data;
using Temple.Net.Models;

namespace Temple.Net.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly UserDbContext _context;
    public HomeController(ILogger<HomeController> logger, UserDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AccountPage()
    {
        var user = _context.Users.FirstOrDefault(x => x.Email == HttpContext.User.FindFirst(ClaimTypes.Email).Value);
        if (user != null)
        {
            UserViewModel viewModel = new()
            {
                Email = user.Email,
                Role = user.Role,
                LastName = user.LastName,
                Otch = user.Otch,
                Name = user.Name,
                Photo = user.Photo
            };

            return View(viewModel);
        }
        else
            return View("AccountPage");
    }

    [HttpPost]
    public IActionResult UpdateProfile(UserViewModel model)
    {
        // var user = _context.Users.FirstOrDefault(x => x.Email == model.Email);
        //
        // user.Photo = model.Photo;
        // user.LastName = model.LastName;
        // user.Otch = model.Otch;
        // user.Name = model.Name;
        // user
        return RedirectToAction("Index");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}