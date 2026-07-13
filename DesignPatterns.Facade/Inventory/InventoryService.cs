namespace DesignPatterns.Facade.Inventory;

public class InventoryService
{
    public void CheckInventory(string productName)
    {
        Console.WriteLine($"Checking inventory for product: {productName}");
    }

    public void UpdateInventory(string productName, int reducedQuantity)
    {
        Console.WriteLine($"Updating inventory for product: {productName}, Quantity: {reducedQuantity} reduced!");
    }


}
