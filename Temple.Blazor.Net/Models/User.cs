using Microsoft.AspNetCore.Identity;

namespace Temple.Net.Models;

public class User : IdentityUser
{
    public string Role { get; set; }
}