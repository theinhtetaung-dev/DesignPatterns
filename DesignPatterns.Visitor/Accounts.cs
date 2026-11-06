namespace DesignPatterns.Visitor;
public interface IAccount { decimal Balance { get; } void Accept(IAccountVisitor visitor); }
public interface IAccountVisitor { void Visit(SavingAccount account); void Visit(BusinessAccount account); }
public class SavingAccount(decimal balance) : IAccount { public decimal Balance { get; } = balance; public void Accept(IAccountVisitor visitor) => visitor.Visit(this); }
public class BusinessAccount(decimal balance) : IAccount { public decimal Balance { get; } = balance; public void Accept(IAccountVisitor visitor) => visitor.Visit(this); }
public class MonthlyFeeVisitor : IAccountVisitor
{
    public void Visit(SavingAccount account) => Console.WriteLine($"Saving account fee: {account.Balance * 0.001m:N2} MMK");
    public void Visit(BusinessAccount account) => Console.WriteLine($"Business account fee: {account.Balance * 0.003m:N2} MMK");
}
