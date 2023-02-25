using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.PowerOf_2
{
    public class PowerOf_2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] result = new BigInteger[n+1];
            for(int i=0; i <= n; i++)
            {
                result[i] =(BigInteger)Math.Pow(2,i) ;
            }

            return result;


            //return (from x in Enumerable.Range(0, n+1) select BigInteger.Pow(2, x)).ToArray();
        }
    }
}
