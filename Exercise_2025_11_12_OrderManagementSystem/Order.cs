namespace Exercise_2025_11_12_OrderManagementSystem
{
    public class Order
    {
        public int OrderNumber { get; set; }

        public int CustomerNumber { get; set; }

        public decimal OrderValue { get; set; }

        public decimal FinalAmount { get; set; }

        public void CalculateFinalAmount(decimal orderValue, int customerNumber, List<Customer> customers)
        {
            decimal finalAmount = 0;
            var customer = new Customer();

            foreach (var item in customers)
            {
                if (item.CustomerNumber == customerNumber)
                {
                    customer = item;
                }
            }

            if (orderValue >= 50 && customer.Type == "Gold")
            {
                finalAmount = Math.Round(
                    orderValue - (orderValue * (customer.DiscountRates[0] + customer.DiscountRates[2]) / 100),
                    2);
            }
            else if (orderValue >= 25 && customer.Type == "Gold")
            {
                finalAmount = Math.Round(
                    orderValue - (orderValue * (customer.DiscountRates[0] + customer.DiscountRates[1]) / 100),
                    2);
            }
            else
            {
                finalAmount = Math.Round(orderValue - (orderValue * customer.DiscountRates[0] / 100), 2);
            }

            FinalAmount = finalAmount;
        }
    }
}
