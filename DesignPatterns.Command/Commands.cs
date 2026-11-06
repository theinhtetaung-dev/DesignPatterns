namespace DesignPatterns.Command;
public class BankAccount(decimal balance)
{
    public decimal Balance { get; private set; } = balance;
    public void Deposit(decimal amount) { Balance += amount; Console.WriteLine($"Balance: {Balance:N2} MMK"); }
    public void Withdraw(decimal amount) { Balance -= amount; Console.WriteLine($"Balance: {Balance:N2} MMK"); }
}
public interface ICommand { void Execute(); void Undo(); }
public class DepositCommand(BankAccount account, decimal amount) : ICommand { public void Execute() => account.Deposit(amount); public void Undo() => account.Withdraw(amount); }
public class WithdrawCommand(BankAccount account, decimal amount) : ICommand { public void Execute() => account.Withdraw(amount); public void Undo() => account.Deposit(amount); }
public class TransactionTerminal
{
    private readonly Stack<ICommand> _history = [];
    public void Execute(ICommand command) { command.Execute(); _history.Push(command); }
    public void UndoLast() { if (_history.TryPop(out var command)) command.Undo(); }
}
