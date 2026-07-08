using DesignPatterns.Builder;

var builder = new TransactionBuilder();

var transfer1 = builder
                .FromAccount("09123456789")
                .ToAccount("09987654321")
                .Amount(50000)
                .Note("Salary")
                .Build();

transfer1.Execute();


var builder2 = new TransactionBuilder();
var internationalTransfer = builder2
    .FromAccount("ACC-98765")
    .ToAccount("ACC-12345")
    .Amount(100)
    .Currency("USD")
    .TransferFee(2.5m)
    .Note("Freelance Payment")
    .Build();

internationalTransfer.Execute();