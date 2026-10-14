namespace OrderManagementSystem.CustomerStatus;

public class SilverCustomerTierService : ICustomerTierService
{
    public string TierName => "Silver";

    public int Discount => 5;

    public int DiscountForOrdersOver50 => 0;

    public int DiscountForOrdersOver25 => 0;
}
