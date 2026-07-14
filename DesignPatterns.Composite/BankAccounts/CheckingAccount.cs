using DesignPatterns.Composite.Interfaces;
using System;

namespace DesignPatterns.Composite.BankAccounts;

public class CheckingAccount : IBankAccount
{
    public string _accountNumber { get; }
    private decimal _balance;

    public CheckingAccount(string accountNumber, decimal balance)
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
