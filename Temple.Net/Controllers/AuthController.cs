using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Temple.Net.Data;
using Temple.Net.Models;
using Temple.Net.Service;

namespace Temple.Net.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    private readonly UserService _userService;

    private UserDbContext _context;

    public AuthController(ILogger<AuthController> logger, UserService userService, UserDbContext context)
    {
        _logger = logger;
        _userService = userService;
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Register(AuthViewModel model)
    {
        User user = new()
        {
            Id = Guid.NewGuid().ToString("N"),
            Email = model.Email,
            Role = "read",
            PasswordHash = await _userService.CreatePasswordHashAsync(model.Password),
            Name = model.Name,
            Otch = model.Otch,
            LastName = model.LastName
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
        var claims = new List<Claim> { new (ClaimTypes.Name, user.Name) };
        var claimsIdentity = new ClaimsIdentity(claims, "Cookie");
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        await HttpContext.SignInAsync(claimsPrincipal);
        
        return RedirectToAction("Index", "Home");
    }
}