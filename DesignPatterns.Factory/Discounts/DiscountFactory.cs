namespace DesignPatterns.Factory.Discounts;
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

