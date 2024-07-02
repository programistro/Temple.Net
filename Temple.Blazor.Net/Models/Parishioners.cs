using System.ComponentModel.DataAnnotations;

namespace Temple.Net.Models;

public class Parishioners
{
    [Key]
    public string Id { get; set; }
    
    public string? TempleName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Name { get; set; }
    
    public DateTime? YearRestart { get; set; }

    public string? Otch { get; set; }
    
    public int? Age { get; set; }
    
    public string? Gender { get; set; }
    
    public string? Adress { get; set; }
    
    public string? Social { get; set; } //социальное происхождение
    
    public string? SocialStatus { get; set; } //Общественное и служебное положение c 1914
    
    public string? EstateBeforeRevolution { get; set; } // Принадлежность к сословию до революции
    
    /// <summary>
    /// Имущественное положение
    /// </summary>
    public string PropertyStatus { get; set; }  
    
    public DateTime? DateJoinRelligios { get; set; } // Время присоединения к религиозному культу

    public DateTime? YearMention { get; set; } // год упоменания
    
    public string? Note { get; set; } // примечания
    
    public string? Source { get; set; }
    
    public string? Photo { get; set; }
    
    public string? File { get; set; }
}