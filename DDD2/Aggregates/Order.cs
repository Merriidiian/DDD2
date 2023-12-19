namespace DDD2.Aggregates;

public class Order
{
    public DetailsOrder DetailsOrder { get; set; }
    public Status Status { get; set; }
    public string[] Products { get; set; }
    public string Address { get; set; }
}

public class DetailsOrder
{
    public Guid Id { get; set; }
    public int Sum { get; set; }
    public DateTime DateTime { get; set; }
}

public enum Status
{
    OK, ERROR, NONE
}