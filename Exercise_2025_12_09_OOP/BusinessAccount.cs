namespace Exercise_2025_12_09_OOP
{
    public abstract class BusinessAccount : Account
    {
        public BusinessAccount(string customerNumber, string accountNumber, string bankCode) :  base (customerNumber, accountNumber, bankCode)
        {

        }
    }
}
