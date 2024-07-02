using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class TempleOriention
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? YearFall { get; set; }
    
    public string? Oriention { get; set; }
    
    public DateTime? YearRefund { get; set; }
}