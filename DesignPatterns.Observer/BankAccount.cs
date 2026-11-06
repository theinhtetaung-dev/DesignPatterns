namespace DesignPatterns.Observer;
public interface IAccountObserver { void Update(string accountNumber, string message); }
public class BankAccount
{
    private readonly List<IAccountObserver> _observers = [];
    private decimal _balance;
    public BankAccount(string accountNumber, decimal balance) { AccountNumber = accountNumber; _balance = balance; }
    public string AccountNumber { get; }
    public void Subscribe(IAccountObserver observer) => _observers.Add(observer);
    public void Unsubscribe(IAccountObserver observer) => _observers.Remove(observer);
    public void Deposit(decimal amount) { _balance += amount; Notify($"Deposited {amount:N2} MMK. Balance: {_balance:N2} MMK"); }
    public void Withdraw(decimal amount) { if (amount > _balance) { Notify("Withdrawal failed: insufficient balance."); return; } _balance -= amount; Notify($"Withdrew {amount:N2} MMK. Balance: {_balance:N2} MMK"); }
    private void Notify(string message) { foreach (var observer in _observers) observer.Update(AccountNumber, message); }
}
public class SmsNotifier(string phoneNumber) : IAccountObserver { public void Update(string accountNumber, string message) => Console.WriteLine($"SMS to {phoneNumber}: [{accountNumber}] {message}"); }
public class EmailNotifier(string email) : IAccountObserver { public void Update(string accountNumber, string message) => Console.WriteLine($"Email to {email}: [{accountNumber}] {message}"); }
