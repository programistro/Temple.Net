using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Parishioners
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? Year { get; set; }
    
    public string Quantity { get; set; }
}