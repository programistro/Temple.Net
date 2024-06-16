namespace Temple.Net.Models;

public class Temple
{
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    public string DateStart { get; set; }
    
    public string DateEnd { get; set; }
    
    public AppointmentsAfterEnd AppointmentsAfterEnd { get; set; }
    
    public string YearDestruction { get; set; }
    
    public TempleOriention Oriention { get; set; }
    
    public Parishioners Parishioners { get; set; }
    
    
}