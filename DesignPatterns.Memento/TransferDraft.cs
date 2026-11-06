namespace DesignPatterns.Memento;
public record TransferMemento(string ToAccount, decimal Amount, string Note);
public class TransferDraft
{
    private string _toAccount = ""; private decimal _amount; private string _note = "";
    public void Set(string toAccount, decimal amount, string note) { _toAccount = toAccount; _amount = amount; _note = note; }
    public TransferMemento CreateMemento() => new(_toAccount, _amount, _note);
    public void Restore(TransferMemento memento) { _toAccount = memento.ToAccount; _amount = memento.Amount; _note = memento.Note; }
    public void Print() => Console.WriteLine($"To: {_toAccount}, Amount: {_amount:N2} MMK, Note: {_note}");
}
public class DraftHistory
{
    private readonly Stack<TransferMemento> _history = [];
    public void Save(TransferMemento memento) => _history.Push(memento);
    public TransferMemento Undo() => _history.Pop();
}
