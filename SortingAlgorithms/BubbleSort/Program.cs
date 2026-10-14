
int[] numbers = { 41, 12, 52, 64, 1, 9 };
int counter = 0;

for (int i = 0; i < numbers.Length / 2 + 1; i++) // WARNING: Flawed optimization. May reduce iterations but elements at the end might not reach the front.
{
    for (int j = 0; j < numbers.Length - 1 - i; j++) // Optimization: Skips already sorted elements at the end of the array.
    {
        counter++;
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

Console.WriteLine(counter);

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

        
        
   





