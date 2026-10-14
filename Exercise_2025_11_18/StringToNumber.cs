namespace Exercise_2025_11_18
{
    public class StringToNumber
    {
        public string CharToNumber(char c)
        {
            string output = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c) { output = Convert.ToString(i+1); break; }
            }
            
            return output;
        }

        public string StringToNumbers(string input) 
        {
            string output = "";

            foreach (char c in input)
            {
                output += CharToNumber(c);
            }

            return output;
        }

        public string StringToNumbersTT(string input)
        {
            string output = "";

            for (int i = 2; i < input.Length - 2; i++)
            {
                output += CharToNumber(input[i]); ;
            }

            return output;
        }

        public string NumberToChar(int input)
        {
            string output = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i == input) { output = Convert.ToString(alphabet[i]); break; }
            }

            return output;
        }

        public String[,] ToLetters(int h, int l) 
        {
            String[,] output = new String[h, l];

            return output;
        }
    }
}
