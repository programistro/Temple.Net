using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class TempleOriention
{
    [Key]
    public string Id { get; set; }
    
    public DateOnly? YearFall { get; set; }
    
    public string? Oriention { get; set; }
    
    public DateOnly? YearRefund { get; set; }
}