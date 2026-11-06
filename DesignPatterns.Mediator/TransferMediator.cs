namespace DesignPatterns.Mediator;
public interface ITransferMediator { void Register(Account account); void Transfer(string from, string to, decimal amount); }
public class TransferMediator : ITransferMediator
{
    private readonly Dictionary<string, Account> _accounts = [];
    public void Register(Account account) => _accounts[account.Name] = account;
    public void Transfer(string from, string to, decimal amount)
    {
        if (_accounts.TryGetValue(to, out var receiver)) receiver.Receive(from, amount);
        else Console.WriteLine($"Account {to} was not found.");
    }
}
public class Account(string name, ITransferMediator mediator)
{
    public string Name { get; } = name;
    public void Transfer(string to, decimal amount) { Console.WriteLine($"{Name} sends {amount:N2} MMK"); mediator.Transfer(Name, to, amount); }
    public void Receive(string from, decimal amount) => Console.WriteLine($"{Name} received {amount:N2} MMK from {from}");
}
