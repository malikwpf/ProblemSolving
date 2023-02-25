using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Sixth.NarcissisticNumbers
{
    public class NarcissisticNumber
    {
        public static bool Narcissistic(int value)
        {
            double sum = 0;
            string digits=value.ToString();
            var intEnumerable=digits.Select(dig=>int.Parse(dig.ToString()));
            var intList=intEnumerable.ToList();

            foreach(var number in intList)
            {
               sum+= Math.Pow(number,intList.Count);
            }

            if(sum==value)
                return true;
            return false;
        }
    }
}
