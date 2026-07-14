using DesignPatterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.BankAccounts;

public class SavingAccount : IBankAccount
{
    public  string _accountNumber { get; }
    private decimal _balance;

    public SavingAccount(string accountNumber, decimal balance)
    {
        _accountNumber = accountNumber;
        _balance = balance;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited {amount:N2} MMK to account {_accountNumber}. New balance: {_balance:N2} MMK");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine($"Insufficient funds in account {_accountNumber}. Current balance: {_balance:N2} MMK");
            return;
        }
        _balance -= amount;
        Console.WriteLine($"Withdrew {amount:N2} MMK from account {_accountNumber}. New balance: {_balance:N2} MMK");
    }

}
