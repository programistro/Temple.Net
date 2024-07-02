using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Education
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? YearAdmission { get; set; }
    
    public string? Institution { get; set; }
    
    public DateTime? YearOfRease { get; set; }
}