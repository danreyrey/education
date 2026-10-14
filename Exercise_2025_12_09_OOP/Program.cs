using Exercise_2025_12_09_OOP;

AccountHolder jeffAggregiert = new AccountHolder("Jeff Rey Aggro", "Eselsweg 35", "Brüggen-Bracht", "6661666"); // Aggregation
PersonalAccount jeff = new PersonalAccount("1", "432095", "3105999", jeffAggregiert); // Composition

// the following two lines result in: "System.NullReferenceException: Object reference not set to an instance of an object."
// jeff = null;
// Console.WriteLine(jeff.GetAccountHolder().GetStreet());

Console.WriteLine(jeff.GetAccountHolder().GetStreet());