namespace Exercise_2025_11_12_OrderManagementSystem
{
    public class CustomerSeeder
    {
        public List<Customer> SeedCustomers(List<Customer> customers)
        {
            customers.Add(new Customer
            {
                CustomerNumber = 21,
                Name = "Achim Hair Salon Supplies Partnership",
                Type = "Gold"
            });

            customers[0].SetCustomerType();

            customers.Add(new Customer
            {
                CustomerNumber = 22,
                Name = "Kevin Sports Supplies Ltd.",
                Type = "Silver"
            });

            customers[1].SetCustomerType();

            customers.Add(new Customer
            {
                CustomerNumber = 23,
                Name = "Silvana Jewelry Wholesale Inc.",
                Type = "Gold"
            });

            customers[2].SetCustomerType();

            customers.Add(new Customer
            {
                CustomerNumber = 24,
                Name = "Gabriele Sausage Trading Company",
                Type = "Standard"
            });

            customers[3].SetCustomerType();

            return customers;
        }
    }
}
