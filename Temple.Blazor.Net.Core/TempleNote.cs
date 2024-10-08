﻿namespace Temple.Core;

public class TempleNote
{
    public Guid Id { get; set; }
    
   public string? Name { get; set; }
    
    public string? Type { get; set; }
    
    public DateOnly? DateStart { get; set; }
    
    public DateOnly? DateEnd { get; set; }

    public AppointmentsAfterEnd? AppointmentsAfterEnd { get; set; } = new();
    
    public DateOnly? YearAdaptation { get; set; }
    
    public DateOnly? YearDestruction { get; set; }

    public List<TempleOriention?>? Oriention { get; set; } = new();
    
    public string? OrientationDiocesse { get; set; }
    
    //public string Diocesse { get; set; }

    public List<ParishionersTemple?>? ParishionersTemple { get; set; } = new();
    
    /// <summary>
    /// Губернии
    /// </summary>
    public string? Province { get; set; }
    
    /// <summary>
    /// Уезды
    /// </summary>
    public string? Counties { get; set; }
    
    public string? District { get; set; } // Округа и районы округов (1924-1930)
    
    /// <summary>
    ///  Округ
    /// </summary>
    public string? Ocrug { get; set; }
    
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

    public double Lat { get; set; }

    public double Lng { get; set; }

    /// <summary>
    /// Год упоминания
    /// </summary>
    public List<DateOnly>? YearReferences { get; set; } = new();

    public string? TempleNameOnMap { get;set; }
    
    /// <summary>
    /// Благоличие
    /// </summary>
    public string? Benevolence { get; set; }
}