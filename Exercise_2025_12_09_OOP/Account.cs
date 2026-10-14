namespace Exercise_2025_12_09_OOP
{
    public abstract class Account
    {
        private string customerNumber;

        private string accountNumber;

        private string bankCode;

        private string IBAN;

        public Account (string customerNumber, string accountNumber, string bankCode)
        {
            this.customerNumber = customerNumber;
            this.accountNumber = accountNumber;
            this.bankCode = bankCode;
            this.IBAN = bankCode + "0000" + accountNumber;
        }

        public string GetCustomerNumber() => this.customerNumber;

        public string GetAccountNumber() => this.accountNumber;

        public string GetBankCode() => this.bankCode;

        public string GetIBAN() => this.IBAN;
    }
}
