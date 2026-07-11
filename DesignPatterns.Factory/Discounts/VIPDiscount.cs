namespace DesignPatterns.Factory.Discounts;

public class VIPDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.7m; // 30% discount
    }
}

