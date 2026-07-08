using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

public class Transaction
{
    public Guid TransactionId { get; set; }
    public string FromAccount { get; set; }
    public string ToAccount { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string Note { get; set; }
    public decimal TransferFee { get; set; }
    public DateTime ScheduledDate { get; set; }

    public void Execute()
    {
        Console.WriteLine("--- Transaction Details ---");
        Console.WriteLine($"ID: {TransactionId}");
        Console.WriteLine($"From: {FromAccount}  ->  To: {ToAccount}");
        Console.WriteLine($"Amount: {Amount:N2} {Currency}");
        Console.WriteLine($"Fee: {TransferFee:N2} {Currency}");
        if (!string.IsNullOrEmpty(Note))
        {
            Console.WriteLine($"Note: {Note}");
        }
        Console.WriteLine($"Date: {ScheduledDate}");
        Console.WriteLine("Status: SUCCESS\n");
    }
}
