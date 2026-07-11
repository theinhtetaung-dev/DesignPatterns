namespace DesignPatterns.Factory.Discounts;

public class PremiumDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.8m; // 20% discount
    }
}

