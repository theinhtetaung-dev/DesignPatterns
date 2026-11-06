namespace DesignPatterns.Strategy;
public interface ITransferFeeStrategy { decimal Calculate(decimal amount); }
public class LocalTransferFee : ITransferFeeStrategy { public decimal Calculate(decimal amount) => amount * 0.005m; }
public class InternationalTransferFee : ITransferFeeStrategy { public decimal Calculate(decimal amount) => amount * 0.025m; }
public class TransferFeeCalculator(ITransferFeeStrategy strategy)
{
    public ITransferFeeStrategy Strategy { private get; set; } = strategy;
    public decimal Calculate(decimal amount) => Strategy.Calculate(amount);
}
