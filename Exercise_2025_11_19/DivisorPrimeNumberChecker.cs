namespace Exercise_2025_11_19
{
    public class DivisorPrimeNumberChecker
    {
        public bool CheckDivisorsForPrimeNumbers(int number)
        {
            bool isMatch = false;

            if (number <= 2)
            {
                isMatch = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        if (CheckDivisor(i) == true)
                        {
                            isMatch = true;
                        }
                        else
                        {
                            isMatch = false;
                        }
                    }
                }
            }
            return isMatch;
        }

        public bool CheckDivisor(int number)
        {
            bool isPrime = false;

            for (int j = 2; j < number; j++) // Reducing the number of loop iterations by taking the square root.
            {
                if (number % j == 0)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime = true;
                }
            }
            return isPrime;
        }
    }
}