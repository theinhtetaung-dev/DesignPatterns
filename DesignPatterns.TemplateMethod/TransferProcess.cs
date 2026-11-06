namespace DesignPatterns.TemplateMethod;
public abstract class TransferProcess
{
    public void Execute(decimal amount) { Validate(amount); CalculateFee(amount); Send(amount); Notify(); }
    protected virtual void Validate(decimal amount) => Console.WriteLine($"Validated {amount:N2}");
    protected abstract void CalculateFee(decimal amount);
    protected abstract void Send(decimal amount);
    protected virtual void Notify() => Console.WriteLine("Customer notified.\n");
}
public class LocalTransfer : TransferProcess
{
    protected override void CalculateFee(decimal amount) => Console.WriteLine($"Local fee: {amount * 0.005m:N2} MMK");
    protected override void Send(decimal amount) => Console.WriteLine("Sent through local network.");
}
public class InternationalTransfer : TransferProcess
{
    protected override void Validate(decimal amount) { base.Validate(amount); Console.WriteLine("KYC check completed."); }
    protected override void CalculateFee(decimal amount) => Console.WriteLine($"International fee: {amount * 0.025m:N2} USD");
    protected override void Send(decimal amount) => Console.WriteLine("Sent through international network.");
}
