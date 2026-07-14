using System;
using DesignPatterns.Composite;
using DesignPatterns.Composite.BankAccounts;
using DesignPatterns.Composite.Interfaces;

Console.OutputEncoding = System.Text.Encoding.UTF8;

IBankAccount saving1 = new SavingAccount("SA-1001", 1000m);
IBankAccount checking1 = new CheckingAccount("CA-2001", 500m);
IBankAccount saving2 = new SavingAccount("SA-1002", 2000m);

Console.WriteLine("Leaf Account Operations ");
saving1.Deposit(200m);
checking1.Withdraw(100m);

IAccountPortfolio personalPortfolio = new AccountPortfolio("Personal Portfolio");
personalPortfolio.Add(saving1);
personalPortfolio.Add(checking1);

IAccountPortfolio businessPortfolio = new AccountPortfolio("Business Portfolio");
businessPortfolio.Add(saving2);

IAccountPortfolio mainPortfolio = new AccountPortfolio("Main Portfolio");
mainPortfolio.Add(personalPortfolio);
mainPortfolio.Add(businessPortfolio);

Console.WriteLine("\nMain Portfolio Operations");
mainPortfolio.GetBalance();

Console.WriteLine("\nAttempting transaction on Portfolio");
mainPortfolio.Deposit(500m);

Console.WriteLine("\nTransaction on Leaf Account under Portfolio");
saving1.Deposit(300m);

Console.WriteLine("\nFinal Main Portfolio Balance");
mainPortfolio.GetBalance();

