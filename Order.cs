namespace ConsoleApp14;

public class Order
{
    public string ProductType { get; set; }
    public int Quantity { get; set; }
    public Client Client { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Detail> Details { get; set; }
}