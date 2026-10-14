namespace OrderManagementSystem.CustomerStatus;

public class GoldCustomerTierService : ICustomerTierService
{
    public string TierName => "Gold";

    public int Discount => 10;

    public int DiscountForOrdersOver50 => 25;

    public int DiscountForOrdersOver25 => 15;
}
