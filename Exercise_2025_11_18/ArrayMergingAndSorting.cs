namespace Exercise_2025_11_18
{
    public class ArrayMergingAndSorting
    {
        public int[] MergingAndSortingTwoArrays()
        {

            // Exercise: Merging and sorting two arrays of type int

            int[] array1 = { 7, 9, 11, 13 };

            int[] array2 = { 8, 10, 12 };

            var mergedArray = array1.Concat(array2).ToArray();

            int temporary;

            for (int i = 0; i <= mergedArray.Length - 2; i++)
            {
                for (int j = 0; j <= mergedArray.Length - 2; j++)
                {
                    if (mergedArray[j] > mergedArray[j + 1])
                    {
                        temporary = mergedArray[j + 1];
                        mergedArray[j + 1] = mergedArray[j];
                        mergedArray[j] = temporary;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in mergedArray)
            {
                Console.Write($"{p} ");
            }
            // Console.ReadLine();


            Console.WriteLine("\n");


            var result = new int[array1.Length + array2.Length];

            int counterA = 0;
            int counterB = 0;

            while (counterA != array1.Length && counterB != array2.Length)
            {
                if (array1[counterA] < array2[counterB])
                {
                    if (counterA == array1.Length - 1)
                    {
                        result[counterA + counterB] = array2[counterB];
                        counterB++;
                    }
                    else if (counterB == array2.Length - 1)
                    {
                        result[counterA + counterB] = array1[counterA];
                        counterA++;
                    }
                    else
                    {
                        result[counterA + counterB] = array1[counterA];
                        counterA++;
                    }
                }
                else if (array1[counterA] > array2[counterB])
                {
                    if (counterA == array1.Length - 1)
                    {
                        result[counterA + counterB] = array2[counterB];
                        counterB++;
                    }
                    else if (counterB == array2.Length - 1)
                    {
                        result[counterA + counterB] = array1[counterA];
                        counterA++;
                    }
                    else
                    {
                        result[counterA + counterB] = array2[counterB];
                        counterB++;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in mergedArray)
            {
                Console.Write($"{p} ");
            }

            return mergedArray;
        }
    }
}