using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Pyament;

public class SystemPayment : IPayment   
{
    public void Pay(string phoneNo, decimal amount)
    {
        Console.WriteLine($"Payment of {amount:N2} made to {phoneNo} using SystemPayment.");
    }
}
