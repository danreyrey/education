
int?[] sorted = insertionSort(new int?[] { 14, 15, 17, 18 }, 13);

foreach (int i in sorted)
    Console.WriteLine(i);

int?[] insertionSort(int?[] arr, int? newValue)
{
    int?[] result = new int?[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (newValue != null && i == arr.Length - 1)
        {
            result[i] = arr[i];
            result[i + 1] = newValue;
            newValue = null;
        }
        else if (arr[i] < newValue)
        {
            result[i] = arr[i];
        }
        else if (arr[i] >= newValue && newValue != null)
        {
            result[i] = newValue;
            newValue = null;
            i--;
        }
        else
        {
            result[i + 1] = arr[i];
        }
    }
    return result;
}