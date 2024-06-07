using Microsoft.AspNetCore.Identity;

namespace Temple.Net.Models;

public class User : IdentityUser
{
    public string Role { get; set; }
    
    public string Name { get; set; }
    
    public string LastName { get; set; }
    
    public string Otch { get; set; }
}