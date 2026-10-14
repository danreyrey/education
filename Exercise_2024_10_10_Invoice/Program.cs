namespace Exercise_2024_10_10_Invoice
{
    class Program
    {
        // Declare global variables here
        static double totalPrice = 0; // static gives the variable the same value in every instance of the Program class
        static double taxPrice = 0; // Declare the taxPrice variable for VAT calculation

        // Main function (entry point of the program)
        static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.ASCII;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Use special character sets

            // Generate the cover letter
            coverLetter();

            // Insert two line breaks / blank lines
            Console.WriteLine("");
            Console.WriteLine("");

            // \t creates a tab of 4 spaces, similar to the tab created by the showPrice function/method
            Console.WriteLine("Article\t\t\tQuantity\t\tPrice\t\tTotal\t\tVAT");

            // Call the showPrice function three times with the respective values for the tabular layout
            showPrice("Egg salad", 1, 3.75);
            showPrice("House slippers", 3, 7.25);
            showPrice("Mashed potatoes", 5, 4.95);

            // Output the total amount
            Console.WriteLine("");
            Console.WriteLine("Total amount\t\t\t" + totalPrice + "€");

            // Output the total VAT
            Console.WriteLine("");
            Console.WriteLine("Total VAT\t\t\t" + taxPrice + "€");
        }

        // Cover letter with the variables name and date
        static void coverLetter()
        {
            string name = "Mr. Herrmann";
            string date = "03.02.2027";

            // @ allows adding text with paragraphs / multiple lines
            Console.WriteLine(
                                @"Hello " + name + @",

                                I am sending you the invoice for my services rendered on " + date + @".
                                Thank you for using our services!

                                Kind regards,

                                Daniel Reynders"
                            );
        }

        // Calculate the total price of individual items, VAT, total amount, and total VAT
        static void showPrice(string article, int amount, double price)
        {
            // Define/declare variables in the method header instead of inside the method body
            // int amount = 3;
            // double price = 7.95;
            double total = amount * price;
            totalPrice = totalPrice + total; // Calculate the total amount of the invoice

            double taxes = total * 0.19;
            taxPrice = taxPrice + taxes; // Calculate the VAT

            // Output the article, quantity, price, total amount (quantity * price), and VAT
            Console.WriteLine(article + "\t\t" + amount + "\t\t" + price + "€\t\t" + total + "€\t\t" + taxes + "€");
        }
    }
}

