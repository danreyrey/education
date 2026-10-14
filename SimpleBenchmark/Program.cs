
var timeStart = DateTime.Now;
for (int i = 1; i < 1000000; i++)
{
    Console.WriteLine(i*100/1000000+"%" + i * i);
    Console.Clear();
}
Console.WriteLine(timeStart - DateTime.Now);