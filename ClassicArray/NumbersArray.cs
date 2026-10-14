namespace ClassicArray;

public class NumbersArray
{
    public int Number;
    public NumbersArray? Num;

    public NumbersArray(int number, NumbersArray num)
    {
        Number = number;
        Num = num;
    }
    
    public NumbersArray(int number)
    {
        Number = number;
    }
}