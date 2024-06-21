using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Temple.Net.Models;

namespace Temple.Blazor.Net.Controllers;

[Microsoft.AspNetCore.Mvc.Route("/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpGet("singin")]
    public async Task<ActionResult> Singin(string email, string name)
    {
        // создаем один claim
        var claims = new List<Claim> { new (ClaimTypes.Name, name), new (ClaimTypes.Email, 
            email), new (ClaimTypes.Role,  "read") };
        var claimsIdentity = new ClaimsIdentity(claims, "Cookie");
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        await HttpContext.SignInAsync(claimsPrincipal);

        return Redirect("/");
    }
    
    [AllowAnonymous]
    [HttpGet("signout")]
    public async Task<ActionResult> signout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        var prop = new AuthenticationProperties
        {
            RedirectUri = "/logout-complete"
        };

        return Redirect("/");
    }
}