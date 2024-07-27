using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class Sun
{
    [Key]
    public string Id { get; set; }
    
    public DateOnly? YearOrdinations { get; set; }
    
    public string? SunName { get; set; }
    
    public DateOnly? YearDefrock { get; set; }
}