namespace Exercise_2025_11_12_OrderManagementSystem
{
    public class Customer
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int CustomerNumber { get; set; }

        public int[] DiscountRates { get; set; }

        public void SetCustomerType()
        {
            var customerTypes = new CustomerType();

            if (Type == "Gold")
            {
                DiscountRates = customerTypes.Gold;
            }
            else if (Type == "Silver")
            {
                DiscountRates = customerTypes.Silver;
            }
            else if (Type == "Standard")
            {
                DiscountRates = customerTypes.Standard;
            }
        }
    }
}
