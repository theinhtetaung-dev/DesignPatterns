using DesignPatterns.Strategy;
var calculator = new TransferFeeCalculator(new LocalTransferFee());
Console.WriteLine($"Local fee: {calculator.Calculate(100000m):N2} MMK");
calculator.Strategy = new InternationalTransferFee();
Console.WriteLine($"International fee: {calculator.Calculate(100000m):N2} MMK");
