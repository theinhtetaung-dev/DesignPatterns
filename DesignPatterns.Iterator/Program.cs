using DesignPatterns.Iterator;
var history = new TransactionHistory();
history.Add(new("TX-001", 1000m));
history.Add(new("TX-002", 2500m));
foreach (var transaction in history) Console.WriteLine($"{transaction.Id}: {transaction.Amount:N2} MMK");
