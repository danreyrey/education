using ClassicArray;

var num = new NumbersArray(4, new NumbersArray(19));

Console.WriteLine(num.Number);

if (num.Num != null)
{
    var current = num.Num;
    while (current != null)
    {
        Console.WriteLine(current.Number);
        current = current.Num;
    }
}
