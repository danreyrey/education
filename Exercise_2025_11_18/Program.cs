namespace Exercise_2025_11_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var merging = new ArrayMergingAndSorting();
            merging.MergingAndSortingTwoArrays();

            var numbering = new StringToNumber();
            Console.WriteLine(numbering.StringToNumbers("FACE"));

            Console.WriteLine(numbering.StringToNumbersTT("TTFACETT"));

        }
    }
}