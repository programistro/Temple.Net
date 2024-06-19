using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Sun
{
    [Key]
    public string Id { get; set; }
    
    public string YearOrdinations { get; set; }
    
    public string SunName { get; set; }
    
    public string YearDefrock { get; set; }
}