using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Education
{
    [Key]
    public string Id { get; set; }
    
    public string YearAdmission { get; set; }
    
    public string Institution { get; set; }
    
    public string YearOfRease { get; set; }
}