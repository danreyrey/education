
double wantedNumber = 211;
double range = 1024;
double threshold = Math.Log2(range);

for (int i = 0; i < threshold; i++)
{
    double middle = Math.Pow(2, i);
    if (middle == wantedNumber)
    {
        Console.WriteLine($"The number {wantedNumber} was found at 2^{i}.");
        break;
    }
    else if (middle > wantedNumber)
    {
        Console.WriteLine($"The number {wantedNumber} is between 2^{i - 1} and 2^{i}.");
        break;
    }
}