using System.Globalization;


// Exercise 9.2.1
try
{
   Console.WriteLine("Hello, World!");
} 
catch (FormatException e)
{
   Console.WriteLine(e);
}
catch (OverflowException e)
{
   Console.WriteLine(e);
}
finally
{
   Console.WriteLine("Bye bye!");
}



// Exercise 9.2.2
// Create an instance of the Random class
Random randomNumberGenerator = new Random();

// Generate a random integer (any value)
int randomInt = randomNumberGenerator.Next();

// Generate a random integer between 0 (inclusive) and 100 (exclusive)
int randomIntBetween0And100 = randomNumberGenerator.Next(100);

// Generate a random integer between 10 (inclusive) and 20 (exclusive)
int randomIntBetween10And20 = randomNumberGenerator.Next(10, 20);

// Generate a random double between 0.0 (inclusive) and 1.0 (exclusive)
double randomDouble = randomNumberGenerator.NextDouble();



// Exercise 9.3.1
try
{
   int numberOfHeads = 0;
   int numberOfTails = 0;

   for (int i = 0; i < 3; i++)
   {
       int randomNumber = randomNumberGenerator.Next();

       if (randomNumber % 2 == 0)
       {
           numberOfHeads++;
       }
       else
       {
           numberOfTails++;
       }
   }

   Console.WriteLine($"It landed on heads {numberOfHeads} times and tails {numberOfTails} times.");
}
catch (Exception e)
{
   Console.WriteLine(e);
}



// Exercise 9.3.2
try
{
   int counterHeads= 0;
   int counterTrails = 0;
   int counter = 0;
   do
   {
       counter++;
       int randomNumber = randomNumberGenerator.Next();
       if (randomNumber % 2 == 0)
       {
           counterHeads++;
           counterTrails = 0;
       }
       else
       {
           counterTrails++;
           counterHeads = 0;
       }
   }
   while (counterHeads < 2 && counterTrails < 2);
   Console.WriteLine($"It took {counter} rolls to get the same roll twice in a row!");
}
catch (Exception e)
{
   Console.WriteLine(e);
}



// Exercise 9.3.3
try
{
   string? pw = "";
   string secret = "";

   do
   {
       Console.WriteLine("Please enter a password: ");
       pw = Console.ReadLine();
       if (pw is not null)
       secret = pw;
   }
   while (secret != pw);
   Console.WriteLine("Signed in!");

}
catch (Exception e)
{
   Console.WriteLine(e);
}



// Exercise 9.3.4
void SeatInCinema (string name, int seatNumber, int row = 1) // set a default value for row, if not specified
{
   if (name == "Jim")
   {
       // call police
   }
   else
   {
       Console.WriteLine($"Hello {name}! Your seat is {(row * 100 + seatNumber)}!");
   }
}

SeatInCinema("Jerry", 45, 3);



// Exercise 9.4.1
DateTime dt = DateTime.Now;
int day = dt.Day;
int month = dt.Month;
string weekday = dt.ToString("dddd", new CultureInfo("en-US"));
int dayOfTheWeek = (int)dt.Day;        

DayOfWeek Weekday(DateTime dt) => dt.DayOfWeek;
Console.WriteLine(Weekday(dt));



string ReturnBirthday(int tag, int monat)
{
   string today = Convert.ToString(DateTime.Now);
   string todaysDayAndMonth = "";
   string input = "";

   if (tag < 10)
   {
       input = Convert.ToString("0" + tag + "." + monat);
   }
   else
   {
       input = Convert.ToString(tag + "." + monat);
   }

   for (int i = 0; i < 5; i++)
   {
       todaysDayAndMonth += today[i];
   }
   if (todaysDayAndMonth == input)
   {
       return "Happy Birthday!";
   }
   return "Happy Not Birthday!";
}

Console.WriteLine(ReturnBirthday(22, 12));



// Exercise 9.4.2
string ReturnWeekday()
{
   DateTime dateTime = DateTime.Now;
   string day = dateTime.ToString("dddd", new CultureInfo("en-US"));
   return day;
}

Console.WriteLine($"Your compensation amounts to {CalculateCompensation(ReturnWeekday())} EUR!");

double CalculateCompensation(string day)
{
   double compensation = 0,xx;
   if (day == "Saturday" ||  day == "Sunday")
   {
       compensation = -1;
   }
   else
   {
       switch (day)
       {
           case "Monday":
               compensation = 500 * 5;
               break;

           case "Tuesday":
               compensation = 500 * 4;
               break;

           case "Wednesday":
               compensation = 500 * 3;
               break;

           case "Thursday":
               compensation = 500 * 2;
               break;

           case "Friday":
               compensation = 500 * 1;
               break;
       }
   }
   return compensation;
}



// Exercise 9.5.1
// Formula: BMI = Weight(kg) / (Height(m))²

double CalculateBMI(double height, double weight) => weight / (height * height);

Console.WriteLine($"Your BMI is: {Math.Round(CalculateBMI(1.8, 85), 2)}");



// Exercise 9.5.2
// Fizzbuzz 1 - 100: divisible by 3 => Fizz, divisible by 5 => Buzz, divisible by 3 and 5 => FizzBuzz

void FizzBuzz()
{
   for (int i = 1; i <= 100; i++)
   {
       if (i % 3 == 0 && i % 5 != 0) 
       {
           Console.WriteLine("Fizz");
       }
       else if (i % 5 == 0 && i % 3 != 0)
       {
           Console.WriteLine("Buzz");
       }
       else if (i % 5 == 0 && i % 3 == 0)
       {
           Console.WriteLine("FizzBuzz");
       }
       else
       {
           Console.WriteLine(i);
       }
   }
}

FizzBuzz();



// Exercise 9.5.3
void CreateField(int a, int b)
{
   for (int i = 1; i <= a; i++)
   {
       for (int j = 1; j <= b; j++)
       {
           Console.Write($"{i}{j} ");
       }
       Console.Write("\n");
   }
}

CreateField(3, 4);