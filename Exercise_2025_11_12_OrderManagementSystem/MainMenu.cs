namespace Exercise_2025_11_12_OrderManagementSystem
{
    public class MainMenu
    {
        public void DisplayMenu(List<Customer> customers, List<Order> orders)
        {
            Console.Clear();

            Console.WriteLine("Welcome to Daniel's Order Management System!\n\n");
            Console.WriteLine("1) Add customer\n\n2) Add order\n\n3) Show orders\n\n4) Search orders by customer number\n\n5) Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter customer number:");
                int customerNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter customer type (Standard/Silver/Gold):");
                string customerType = Console.ReadLine();

                customers.Add(new Customer
                {
                    Name = name,
                    CustomerNumber = customerNumber,
                    Type = customerType
                });

                var customer = new Customer();
                var counter = 0;
                foreach (var item in customers)
                {
                    if (item.CustomerNumber == customerNumber)
                    {
                        customer = item;
                        customer.SetCustomerType();
                        customers[counter] = customer;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                Console.WriteLine("\n\nCustomer added successfully!\n\n");
                Console.WriteLine("Press Enter to return to the main menu.");
                var inputTmp = Console.ReadLine();
            }
            else if (input == "2")
            {
                Console.WriteLine("Enter customer number:");
                int customerNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter order value:");
                decimal orderValue = Convert.ToDecimal(Console.ReadLine());

                orders.Add(new Order
                {
                    OrderNumber = orders.Count() + 1,
                    CustomerNumber = customerNumber,
                    OrderValue = orderValue
                });

                var order = new Order();
                var counter = 0;
                foreach (var item in orders)
                {
                    if (item.CustomerNumber == customerNumber)
                    {
                        order = item;
                        order.CalculateFinalAmount(orderValue, customerNumber, customers);
                        orders[counter] = order;
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                Console.WriteLine("Order added successfully!\n\nFinal amount: " + orders[counter].FinalAmount + " €");
                Console.WriteLine("Press Enter to return to the main menu.");
                var inputTmp = Console.ReadLine();
            }
            else if (input == "3")
            {
                var customerName = "";
                var output = "";

                foreach (var order in orders)
                {
                    foreach (var customer in customers)
                    {
                        if (customer.CustomerNumber == order.CustomerNumber)
                        {
                            customerName = customer.Name;
                            output = customerName + " – Order value: " + order.OrderValue + " €" +
                                " – Final amount: " + order.FinalAmount + " €" + "\n";
                            Console.WriteLine(output);
                            Thread.Sleep(600);
                        }
                    }
                }

                Console.WriteLine("Press Enter to return to the main menu.");
                var inputTmp = Console.ReadLine();
            }
            else if (input == "4")
            {
                List<int> customerNumbers = new List<int>();
                for (int i = 0; i < customers.Count(); i++)
                {
                    customerNumbers.Add(customers[i].CustomerNumber);
                }
                int[] customerNumberArray = customerNumbers.ToArray();

                Console.WriteLine("Enter a number to search for a customer:");
                var searchNumber = Console.ReadLine();

                var customerSearch = new CustomerSearch();

                List<int> matchingCustomerNumbers = customerSearch.FindCustomerNumbers(customerNumberArray, searchNumber);

                foreach (int number in matchingCustomerNumbers)
                {
                    int index = customers.FindIndex(customer => customer.Name == "Ben");
                    Console.WriteLine("Customer number: " + number + " " + customers[index].Name);
                }

                Console.WriteLine("Press Enter to return to the main menu.");
                var inputTmp = Console.ReadLine();
            }
            else if (input == "5")
            {
                Environment.Exit(0);
            }

            DisplayMenu(customers, orders);
        }
    }
}
