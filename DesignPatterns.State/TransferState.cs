namespace DesignPatterns.State;
public interface ITransferState { void Process(MoneyTransfer transfer); }
public class PendingState : ITransferState { public void Process(MoneyTransfer transfer) { Console.WriteLine("Validating pending transfer..."); transfer.State = new ProcessingState(); } }
public class ProcessingState : ITransferState { public void Process(MoneyTransfer transfer) { Console.WriteLine("Processing transfer..."); transfer.State = new CompletedState(); } }
public class CompletedState : ITransferState { public void Process(MoneyTransfer transfer) => Console.WriteLine("Transfer is already completed."); }
public class MoneyTransfer
{
    public ITransferState State { private get; set; } = new PendingState();
    public void Process() => State.Process(this);
}
