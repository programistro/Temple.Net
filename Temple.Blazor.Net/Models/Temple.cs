﻿using System.Runtime.InteropServices.JavaScript;

namespace Temple.Net.Models;

public class Temple
{
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public DateTime? DateStart { get; set; }
    
    public DateTime? DateEnd { get; set; }
    
    public AppointmentsAfterEnd AppointmentsAfterEnd { get; set; }
    
    public DateTime? YearDestruction { get; set; }
    
    public TempleOriention Oriention { get; set; }
    
    public Parishioners Parishioners { get; set; }
    
    public string OrientationDiocesse { get; set; }
    
    public string Diocesse { get; set; }
    
    public string Province { get; set; }
}