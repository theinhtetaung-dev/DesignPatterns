namespace DesignPatterns.Composite.Interfaces;

public interface IBankAccount
{
    string _accountNumber { get; }
    decimal GetBalance();
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}
