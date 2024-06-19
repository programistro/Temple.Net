using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class MeasuresState
{
    [Key]
    public string Id { get; set; }
    
    public string YearArrest { get; set; }
    
    public string Verdict { get; set; }
    
    public string YearSentence { get; set; }
    
    public string YearRehabilitation { get; set; }
    
    public string Rehabilitaion { get; set; }
}