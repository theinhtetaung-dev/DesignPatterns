using DesignPatterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.BankAccounts;

public class AccountPortfolio : IAccountPortfolio
{
    public string _accountNumber { get; }
    private List<IBankAccount> accounts = new List<IBankAccount>();

    public AccountPortfolio(string name)
    {
        _accountNumber = name;
    }

    public void Add(IBankAccount account)
    {
        accounts.Add(account);
        Console.WriteLine($"Added {account._accountNumber} to  '{_accountNumber}'.");
    }

    public void Remove(IBankAccount account)
    {
        accounts.Remove(account);
        Console.WriteLine($"Removed {account._accountNumber} from  '{_accountNumber}'.");
    }

    public decimal GetBalance()
    {
        decimal total = accounts.Sum(a => a.GetBalance());
        Console.WriteLine($" {_accountNumber} Total Balance: {total:N2} MMK");
        return total;
    }

    public void Deposit(decimal amount)
    {
        Console.WriteLine($"Direct deposits to  '{_accountNumber}' are not supported.");
    }

    public void Withdraw(decimal amount)
    {
        Console.WriteLine($"Direct withdrawals from  '{_accountNumber}' are not supported.");
    }

    public IEnumerable<IBankAccount> GetChildren() => accounts;
}
