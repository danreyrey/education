namespace Exercise_2025_11_12_OrderManagementSystem
{
    public class CustomerSearch
    {
        public List<int> FindCustomerNumbers(int[] customerNumbers, string searchValue)
        {
            List<int> results = new List<int>();
            int matchedCharacters = 0;

            for (int i = 0; i < customerNumbers.Length; i++)
            {
                for (int j = 0; j < customerNumbers[i].ToString().Length; j++)
                {
                    if (customerNumbers[i].ToString()[j] == searchValue[matchedCharacters])
                    {
                        matchedCharacters++;
                    }
                    else
                    {
                        matchedCharacters = 0;
                    }

                    if (matchedCharacters == searchValue.Length)
                    {
                        results.Add(customerNumbers[i]);
                        matchedCharacters = 0;
                        break;
                    }
                }
            }

            return results;
        }
    }
}
