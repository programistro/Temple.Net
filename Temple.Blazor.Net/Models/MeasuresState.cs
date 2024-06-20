using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class MeasuresState
{
    [Key]
    public string Id { get; set; }
    
    public DateTime? YearArrest { get; set; }
    
    public string Verdict { get; set; }
    
    public DateTime? YearSentence { get; set; }
    
    public DateTime? YearRehabilitation { get; set; }
    
    public string Rehabilitaion { get; set; }
}