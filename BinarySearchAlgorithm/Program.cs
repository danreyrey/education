
// int start = 0;
int max = 1000;
int current = max / 2;

int number = 500;
int counter = 1;

while (number != current)
{
    max /= 2;
    if (number > current)
    {
        current += max / 2;
    }
    else
    {
        current -= max / 2;
    }
    counter++;
}

Console.WriteLine("Number was found after " + counter + " iterations");