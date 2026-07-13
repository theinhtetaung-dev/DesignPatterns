using DesignPatterns.Facade;
using DesignPatterns.Facade.Delivery;
using DesignPatterns.Facade.Inventory;
using DesignPatterns.Facade.Payment;

InventoryService inventoryService = new InventoryService();
PaymentService paymentService = new PaymentService();
DeliveryService delieveryService = new DeliveryService();

OrderFacade orderFacade = new OrderFacade(inventoryService, paymentService, delieveryService);
orderFacade.PlaceOrder("Laptop", 1, "1234567890", 10000000.00m, "123 Main St, City, Country");