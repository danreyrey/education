namespace OrderManagementSystem.CustomerStatus;

public interface ICustomerTierService
{
    string TierName { get; }

    int Discount { get; }

    int DiscountForOrdersOver50 { get; }

    int DiscountForOrdersOver25 { get; }
}
