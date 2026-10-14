using Exercise_2025_11_12_OrderManagementSystem;

List<Customer> customers = new List<Customer>();

var customerSeeder = new CustomerSeeder();
customers = customerSeeder.SeedCustomers(customers);

List<Order> orders = new List<Order>();

var mainMenu = new MainMenu();
mainMenu.DisplayMenu(customers, orders);
