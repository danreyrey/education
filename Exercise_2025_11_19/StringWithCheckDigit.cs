namespace Exercise_2025_11_19
{
    public class StringWithCheckDigit
    {
        public bool ValidateStringWithCheckDigit(string input)
        {
            bool isValid = false;

            int checkDigit = GetCheckDigit(input);
            int digitSum = CalculateDigitSum(input);

            isValid = ValidateDigit(digitSum, checkDigit);

            return isValid;
        }

        public int CalculateDigitSum(string input)
        {
            int total = 0;

            for (int i = 3; i <= 11; i += 2)
            {
                if (i == 11)
                {
                    total += (int)Char.GetNumericValue(input[i]);
                }
                else
                {
                    int firstDigit = (int)Char.GetNumericValue(input[i]);
                    int secondDigit = (int)Char.GetNumericValue(input[i + 1]);
                    total += firstDigit + secondDigit * 3;
                }
            }

            return total;
        }

        public int GetCheckDigit(string input)
        {
            int checkDigit = 0;
            string digits = "";

            for (int i = 12; i < input.Length; i++)
            {
                digits += input[i];
            }

            checkDigit = int.Parse(digits);

            return checkDigit;
        }

        public bool ValidateDigit(int digitSum, int checkDigit)
        {
            bool isValid = false;
            int result = digitSum;

            while (result % 10 != 0)
            {
                result++;
            }

            if (result - digitSum == checkDigit)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}

