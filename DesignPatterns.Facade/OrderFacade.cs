using DesignPatterns.Facade.Delivery;
using DesignPatterns.Facade.Inventory;
using DesignPatterns.Facade.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DesignPatterns.Facade;

public class OrderFacade
{
    private readonly InventoryService _inventoryService;
    private readonly PaymentService _paymentService;
    private readonly DeliveryService _delieveryService;

    public OrderFacade(InventoryService inventoryService, PaymentService paymentService, DeliveryService delieveryService)
    {
        _inventoryService = inventoryService;
        _paymentService = paymentService;
        _delieveryService = delieveryService;
    }

    public void PlaceOrder(string productName, int quantity, string mobileNo, decimal amount, string address)
    {
        try
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _inventoryService.CheckInventory(productName);

                _inventoryService.UpdateInventory(productName, quantity);

                if (!_paymentService.Payment(mobileNo, amount))
                {
                    Console.WriteLine("Payment failed. Order not placed.");
                    Console.WriteLine("Rolling back the transaction...");
                    return;
                }

                _delieveryService.DeliverProduct(productName, address);
                scope.Complete();
                Console.WriteLine("Order placed successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while placing the order: " + ex.Message);
        }

    }
}
