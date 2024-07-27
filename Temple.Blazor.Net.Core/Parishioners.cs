using System.ComponentModel.DataAnnotations;

namespace Temple.Core;

public class Parishioners
{
    [Key]
    public string Id { get; set; }
    
    public string? TempleName { get; set; }
    
    public string? LastName { get; set; }
    
    public string? Name { get; set; }
    
    public DateOnly? YearRestart { get; set; }

    public string? Otch { get; set; }
    
    public int? Age { get; set; }
    
    public string? Gender { get; set; }
    
    public string? Adress { get; set; }
    
    /// <summary>
    /// Cоциальное происхождение
    /// </summary>
    public string? Social { get; set; } //
    
    /// <summary>
    /// Общественное и служебное положение c 1914
    /// </summary>
    public string? SocialStatus { get; set; }
    
    /// <summary>
    /// Принадлежность к сословию до революции
    /// </summary>
    public string? EstateBeforeRevolution { get; set; }
    
    /// <summary>
    /// Имущественное положение
    /// </summary>
    public string PropertyStatus { get; set; }  
    
    /// <summary>
    ///  Время присоединения к религиозному культу
    /// </summary>
    public DateOnly? DateJoinRelligios { get; set; }

    /// <summary>
    /// Год упоменания
    /// </summary>
    public DateOnly? YearMention { get; set; }
    
    /// <summary>
    /// Примечания
    /// </summary>
    public string? Note { get; set; }
    
    public string? Source { get; set; }
    
    public string? Photo { get; set; }
    
    public string? File { get; set; }
}