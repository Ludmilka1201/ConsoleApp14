namespace ConsoleApp14;

public class ProductionPlan
{
    public Order Order { get; set; }
    public int TotalTime { get; set; }
    public List<Detail> Details { get; set; }
    public List<Material> Materials { get; set; }
}