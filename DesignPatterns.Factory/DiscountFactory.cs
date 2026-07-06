using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory;

public interface IDiscount
{
    decimal Calculate(decimal amount);
}

public class RegularDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.9m; // 10% discount
    }
}

public class PremiumDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.8m; // 20% discount
    }
}

public class VIPDiscount : IDiscount
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.7m; // 30% discount
    }
}
public class DiscountFactory
{
    public static IDiscount GetDiscount(CustomerType customerType)
    {
        switch(customerType)
        {
            case CustomerType.Regular:
                return new RegularDiscount();
            case CustomerType.Premium:
                return new PremiumDiscount();
            case CustomerType.VIP:
                return new VIPDiscount();
            default:
                throw new ArgumentException("Invalid customer type");
        }
    }
}

