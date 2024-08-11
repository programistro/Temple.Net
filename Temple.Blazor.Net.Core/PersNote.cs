using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class PersNote
{
    [Key]
    public string Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Otch { get; set; }
    
    public string? MonaxName { get; set; }
    
    public string? Nation { get; set; }
    
    public string? PlaceOfDeath { get; set; }
    
    public string? SocialOrigin { get; set; }
    
    public string? Note { get; set; }
    
    public string? Source { get; set; }
    
    /// <summary>
    ///  место рождения
    /// </summary>
    public string? PlaceBirths { get; set; }
    
    public string? LVLEducation { get; set; }   
}