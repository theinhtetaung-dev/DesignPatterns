namespace DesignPatterns.Factory.Discounts;

public class RegularDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.9m; // 10% discount
    }
}

