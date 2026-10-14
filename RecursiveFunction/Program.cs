
void ToBinary(int dec, string resultTemp)
{
   if (dec == 0)
   {
       ReverseString(resultTemp);
   }
   else
   {
       ComputeModulo(dec, resultTemp);

   }
}

void ReverseString(string tempResult)
{
   string result = "";
   for (int i = tempResult.Length; i > 0; i--)
   {
       result += tempResult[i - 1];
   }
   Console.WriteLine(result);
}

void ComputeModulo(int dec, string tempResult)
{
   int decMod = dec % 2;
   dec = dec / 2;
   tempResult += decMod;
   ToBinary(dec, tempResult);
}

ToBinary(1024, "");
