using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class MeasuresState
{
    [Key]
    public string Id { get; set; }
    
    public DateOnly? YearArrest { get; set; }
    
    public string? Verdict { get; set; }
    
    public DateOnly? YearSentence { get; set; }
    
    public DateOnly? YearRehabilitation { get; set; }
    
    public string? Rehabilitaion { get; set; }
}