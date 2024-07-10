using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Temple.Net.Models;

public class Temple
{
    [Key]
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string? Type { get; set; }
    
    public DateTime? DateStart { get; set; }
    
    public DateTime? DateEnd { get; set; }
    
    public AppointmentsAfterEnd? AppointmentsAfterEnd { get; set; }
    
    public DateTime? YearAdaptation { get; set; }
    
    public DateTime? YearDestruction { get; set; }
    
    public TempleOriention? Oriention { get; set; }
    
    public DateTime? ParshYear { get; set; }
    
    public int? Quantity { get; set; }
    
    public string? OrientationDiocesse { get; set; }
    
    //public string Diocesse { get; set; }
    
    public string? Province { get; set; } // Губернии и уезды
    
    public string? District { get; set; } // Округа и районы округов (1924-1930)
    
    /// <summary>
    /// Район округа
    /// </summary>
    public string? RayonDistrict { get; set; }
    
    /// <summary>
    /// Область
    /// </summary>
    public string? Region { get; set; }
    
    /// <summary>
    /// Район области
    /// </summary>
    public string? RayonRegion { get; set; }
    
    /// <summary>
    /// Отедельный район
    /// </summary>
    public string? SeparateRegion { get; set; }
    
    /// <summary>
    /// Тип населеного пункта
    /// </summary>
    public string? TypeLocality { get; set; }
    
    /// <summary>
    /// Населенай пункт
    /// </summary>
    public string? Locality { get; set; }
}