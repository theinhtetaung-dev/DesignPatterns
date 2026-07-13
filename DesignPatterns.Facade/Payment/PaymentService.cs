using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Payment;

public class PaymentService
{
    public bool Payment(string mobileNo, decimal amount)
    {
        Console.WriteLine($"Processing payment Mobile No : {mobileNo}, Amount: {amount:N2} MMK");
        return true; 
    }
}
