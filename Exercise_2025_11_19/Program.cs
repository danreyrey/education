using Exercise_2025_11_19;

var checker = new DivisorPrimeNumberChecker();

for (int i = 1; i <= 120; i++)
{
bool isPrimeDivisorMatch = checker.CheckDivisorsForPrimeNumbers(99);

if (isPrimeDivisorMatch == true)
{
    Console.WriteLine("99" + " = True");
}
else
{
    Console.WriteLine(i + " = False");
}
}

var checkDigitStringChecker = new StringWithCheckDigit();

bool result = checkDigitStringChecker.ValidateStringWithCheckDigit("XX:3513124144");

Console.WriteLine(result);