namespace DesignPatterns.Adapter.Pyament;

public interface IPayment
{
    public void Pay(string phoneNo, decimal amount);
}
