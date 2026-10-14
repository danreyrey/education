namespace OrderManagementSystem.CustomerStatus;

public class StandardCustomerTierService : ICustomerTierService
{
    public string TierName => "Standard";

    public int Discount => 0;

    public int DiscountForOrdersOver50 => 0;

    public int DiscountForOrdersOver25 => 0;
}
