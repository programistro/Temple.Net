using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class Education
{
    [Key]
    public string Id { get; set; }
    
    public DateOnly? YearAdmission { get; set; }
    
    public string? Institution { get; set; }
    
    public DateOnly? YearOfRease { get; set; }
}