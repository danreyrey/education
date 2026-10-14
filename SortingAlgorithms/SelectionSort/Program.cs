
int[] selectionSort = { 41, 12, 52, 64, 1, 9 };
int counter = 0;

for (int i = 0; i < selectionSort.Length - 1; i++)
{
    int index = i;
    for (int j = i + 1; j < selectionSort.Length; j++)
    {
        counter++;
        if (selectionSort[j] < selectionSort[index])
        {
            index = j;
        }
    }
    int temp = selectionSort[i];
    selectionSort[i] = selectionSort[index];
    selectionSort[index] = temp;
}

Console.WriteLine(counter);

foreach (int i in selectionSort)
Console.WriteLine(i);