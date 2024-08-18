using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Temple.Core;

public class Parsonalion
{
    [Key]
    public string Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Otch { get; set; }
    
    public string? MonaxName { get; set; }
    
    public DateOnly? Born { get; set; }
    
    public DateOnly? Death { get; set; }
    
    public string? Nation { get; set; }
    
    public string? PlaceOfDeath { get; set; }
    
    public string? SocialOrigin { get; set; }
    
    public List<Education>? Education { get; set; }
    
    public List<Sun>? Sun { get; set; }
    
    public List<Award>? Award { get; set; }
    
    public List<TempleOriention>? Oriention { get; set; }
    
    public List<MeasuresState>? State { get; set; }
    
    public DateOnly? YearMention { get; set; }
    
    public string? Note { get; set; }
    
    public string? Source { get; set; }
    
    /// <summary>
    ///  место рождения
    /// </summary>
    public string? PlaceBirths { get; set; }
    
    public List<string>? LVLEducation { get; set; }
    
    public string? Photo { get; set; }
    
    public string? File { get; set; } 
}