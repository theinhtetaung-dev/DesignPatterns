using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Delivery;

public class DeliveryService
{
    public void DeliverProduct(string productName, string address)
    {
        Console.WriteLine($"Delivering product: {productName} to address: {address}");
    }
}
