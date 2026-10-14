namespace Exercise_2025_12_09_OOP
{
    public class AccountHolder
    {
        private string Name;

        private string Street;

        private string PostalCode;

        private string City;

        public AccountHolder(string name, string street, string postalCode, string city)
        {
            this.Name = name;
            this.Street = street;
            this.PostalCode = postalCode;
            this.City = city;
        }

        public string GetName() => this.Name;

        public string GetStreet() => this.Street;

        public void SetStreet(string newStreet) => this.Street = newStreet;

        public string GetPostalCode() => this.PostalCode;

        public void SetPostalCode(string newPostalCode) => this.PostalCode = newPostalCode;

        public string GetCity() => this.City;

        public void SetCity(string newCity) => this.City = newCity;

    }
}
