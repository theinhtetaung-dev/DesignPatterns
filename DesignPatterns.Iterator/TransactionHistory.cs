using System.Collections;
namespace DesignPatterns.Iterator;
public record Transaction(string Id, decimal Amount);
public class TransactionHistory : IEnumerable<Transaction>
{
    private readonly List<Transaction> _transactions = [];
    public void Add(Transaction transaction) => _transactions.Add(transaction);
    public IEnumerator<Transaction> GetEnumerator()
    {
        for (var index = _transactions.Count - 1; index >= 0; index--) yield return _transactions[index];
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
