namespace DesignPatterns.Composite.Interfaces;

public interface IAccountPortfolio : IBankAccount
{
    void Add(IBankAccount account);
    void Remove(IBankAccount account);
    IEnumerable<IBankAccount> GetChildren();
}
