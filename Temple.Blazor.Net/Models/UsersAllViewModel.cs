namespace Temple.Net.Models;

public class UsersAllViewModel
{
    public List<User> Users = new();
    
    public UserViewModel User { get; set; }
}