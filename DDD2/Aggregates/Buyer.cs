namespace DDD2.Aggregates;

public class Buyer
{
    public Client Client { get; set; }
    public TypeCard TypeCard { get; set; }
    public MethodBuy MethodBuy { get; set; }
}

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
}

public enum TypeCard
{
    MIR, VISA, MC
}

public enum MethodBuy
{
    Card, Cash, Check
}
