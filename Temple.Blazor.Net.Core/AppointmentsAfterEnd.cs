using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class AppointmentsAfterEnd
{
    [Key]
    public string Id { get; set; }
    
    public string? Appointmenrs { get; set; } 
    
    public DateOnly? Year { get; set; }
}