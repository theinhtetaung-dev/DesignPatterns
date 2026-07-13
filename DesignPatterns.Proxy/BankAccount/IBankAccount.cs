namespace DesignPatterns.Proxy.BankAccount;

public interface IBankAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}
