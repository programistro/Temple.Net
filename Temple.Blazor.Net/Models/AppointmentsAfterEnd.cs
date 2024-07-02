using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class AppointmentsAfterEnd
{
    [Key]
    public string Id { get; set; }
    
    public string? Appointmenrs { get; set; } 
}