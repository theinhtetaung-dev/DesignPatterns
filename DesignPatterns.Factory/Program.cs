// See https://aka.ms/new-console-template for more information
using DesignPatterns.Factory;
using DesignPatterns.Factory.Discounts;

Console.Write("Input Amount : ");
decimal amount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Select Customer Type : ");
Console.WriteLine("1. Regular");
Console.WriteLine("2. Premium");
Console.WriteLine("3. VIP");
Console.WriteLine("Enter your choice (1-3): ");
int choice = Convert.ToInt32(Console.ReadLine());

CustomerType selectedRole;

switch (choice)
{
    case 1:
        selectedRole = CustomerType.Regular;
        break;
    case 2:
        selectedRole = CustomerType.Premium;
        break;
    case 3:
        selectedRole = CustomerType.VIP;
        break;
    default:
        Console.WriteLine("Invalid choice. Defaulting to Regular.");
        selectedRole = CustomerType.Regular;
        break;
}

IDiscount discount = DiscountFactory.GetDiscount(selectedRole); // Default to Regular
discount.Calculate(amount);

Console.WriteLine("Amount is : " + amount);
Console.WriteLine("Discounted Amount is : " + discount.Calculate(amount));
Console.WriteLine("Customer Type is : " + selectedRole);
Console.WriteLine("Press any key to exit...");