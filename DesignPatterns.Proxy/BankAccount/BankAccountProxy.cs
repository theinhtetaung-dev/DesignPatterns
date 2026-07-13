using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.BankAccount;

public class BankAccountProxy : IBankAccount
{
    private readonly BankAccount _bankAccount;
    private string _otp;

    public BankAccountProxy(BankAccount bankAccount,string otp)
    {
        _bankAccount = bankAccount;
        _otp = otp;
    }

    public void Deposit(decimal amount)
    {
        if ( _otp != "123456")
        {
            Console.WriteLine("Authentication failed. Deposit operation denied.");
            return;
        }
        _bankAccount.Deposit(amount);
    }

    public void Withdraw(decimal amount)
    {
        if (_otp != "123456")
        {
            Console.WriteLine("Authentication failed. Withdraw operation denied.");
            return;
        }
        _bankAccount.Withdraw(amount);
    }

}
