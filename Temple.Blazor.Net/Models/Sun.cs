using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Sun
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? YearOrdinations { get; set; }
    
    public string SunName { get; set; }
    
    public DateTime? YearDefrock { get; set; }
}