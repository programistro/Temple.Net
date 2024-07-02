using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Award
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? YearAward { get; set; }
    
    public string? Name { get; set; }
}