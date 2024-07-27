using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class Award
{
    [Key]
    public string Id { get; set; }
    
    public DateOnly? YearAward { get; set; }
    
    public string? Name { get; set; }
}