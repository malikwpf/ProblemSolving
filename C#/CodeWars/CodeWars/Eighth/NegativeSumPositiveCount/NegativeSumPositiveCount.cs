using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.NegativeSumPositiveCount
{
    public class NegativeSumPositiveCount
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0) return Enumerable.Empty<int>().ToArray();

            int positiveCount=input.Where(x => x>0).Count();
            int negativeSum=input.Where(x => x<0).Sum();

            int []result = {positiveCount,negativeSum};

            foreach(var num in result)
                Console.Write(num.ToString()+" ");
            return result;

        }
    }
}
