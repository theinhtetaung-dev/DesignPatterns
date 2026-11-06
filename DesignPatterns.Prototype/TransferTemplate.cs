namespace DesignPatterns.Prototype;
public class TransferTemplate(string name, string fromAccount, decimal amount, List<string> tags)
{
    public string Name { get; set; } = name;
    public string FromAccount { get; set; } = fromAccount;
    public decimal Amount { get; set; } = amount;
    public List<string> Tags { get; set; } = tags;
    public TransferTemplate Clone() => new(Name, FromAccount, Amount, [.. Tags]);
    public void Print() => Console.WriteLine($"{Name}: {Amount:N2} MMK ({string.Join(", ", Tags)})");
}
