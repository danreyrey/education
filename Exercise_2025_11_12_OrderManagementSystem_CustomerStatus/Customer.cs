namespace OrderManagementSystem.CustomerStatus;

public class Customer
{
    private ICustomerTierService? _customerTierService;

    public int CustomerNumber { get; set; }

    public string Name { get; set; } = string.Empty;

    public string CustomerTier { get; private set; } = string.Empty;

    public void SetCustomerTier(string tierName)
    {
        switch (tierName)
        {
            case "Gold":
                _customerTierService = new GoldCustomerTierService();
                break;
            case "Silver":
                _customerTierService = new SilverCustomerTierService();
                break;
            case "Standard":
                _customerTierService = new StandardCustomerTierService();
                break;
            default:
                return;
        }

        CustomerTier = _customerTierService.TierName;
    }

    public decimal CalculateFinalAmount(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);

        var tierService = _customerTierService
            ?? throw new InvalidOperationException("Set the customer tier before calculating the final amount.");

        var additionalDiscount = CustomerTier == "Gold"
            ? order.OrderValue >= 50
                ? tierService.DiscountForOrdersOver50
                : order.OrderValue >= 25
                    ? tierService.DiscountForOrdersOver25
                    : 0
            : 0;

        var totalDiscount = tierService.Discount + additionalDiscount;
        return order.OrderValue - (order.OrderValue * totalDiscount / 100);
    }
}