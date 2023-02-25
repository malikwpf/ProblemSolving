using System.Collections.Generic;
namespace CodeWars.Sixth.RomanNumeralsEncoder
{
    public class RomanNumerals
    {
        public static int Solution(string roman)
        {
            int result = default;
            bool flag = false;
            IDictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000}
            };

            int i=0;
            for (i = 0; i < roman.Length -1; i++)
            {
                if (dictionary[roman[i].ToString()] >= dictionary[roman[i + 1].ToString()])
                {
                    result +=dictionary[roman[i].ToString()];
                }

                else
                {
                    result += dictionary[roman[i+1].ToString()]-dictionary[roman[i].ToString()];
                    i++;
                    if (i == roman.Length - 1)
                    {
                        flag = true;
                    }
                }
            }

            if(flag is false)
                result += dictionary[roman[i].ToString()];

            return result;
        }
    }
}
