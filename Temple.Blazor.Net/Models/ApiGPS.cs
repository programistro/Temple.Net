namespace Temple.Net.Models;

public class AreaInfo
{
    public string Full_Name { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
}

public class RootObject
{
    public AreaInfo area_info { get; set; }
}
