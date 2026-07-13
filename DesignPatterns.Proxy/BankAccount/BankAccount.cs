using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BankAccount;
public class BankAccount : IBankAccount
{
    private string _mobileNo { get; set; } = null!;
    
    private string _password { get; set; } = null!;

    private decimal _balance { get; set; }


    public BankAccount(string mobileNo, string password, decimal balance)
    {
        _mobileNo = mobileNo;
        _password = password;
        _balance = balance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited {amount:N2} MMK. New balance: {_balance:N2} MMK");
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
        Console.WriteLine($"Withdrew {amount:N2} MMK. New balance: {_balance:N2} MMK");
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public string GetPasswrod()
    {
        return _password;
    }
}
