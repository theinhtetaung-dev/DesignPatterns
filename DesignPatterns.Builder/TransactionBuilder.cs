using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

public class TransactionBuilder
{
    private Transaction _transaction;

    public TransactionBuilder()
    {
        _transaction = new Transaction
        {
            TransactionId = Guid.NewGuid(),
            Currency = "MMK",
            ScheduledDate = DateTime.Now,
            TransferFee = 0
        };
    }

    public TransactionBuilder FromAccount(string fromAccount)
    {
        _transaction.FromAccount = fromAccount;
        return this;
    }

    public TransactionBuilder ToAccount(string toAccount)
    {
        _transaction.ToAccount = toAccount;
        return this;
    }

    public TransactionBuilder Amount(decimal amount)
    {
        _transaction.Amount = amount;
        return this;
    }

    public TransactionBuilder Currency(string currency)
    {
        _transaction.Currency = currency;
        return this;
    }

    public TransactionBuilder Note(string note)
    {
        _transaction.Note = note;
        return this;
    }

    public TransactionBuilder TransferFee(decimal transferFee)
    {
        _transaction.TransferFee = transferFee;
        return this;
    }

    public Transaction Build()
    {
        return _transaction;
    }
}
