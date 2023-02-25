using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.MultiplyArrayElements
{
    public class MultiplyArrayElements
    {
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;


            //Second way
            //return Array.ConvertAll(x, n => n * 2);

            //First way
            //return x.Select(r => r * 2).ToArray();
        }
    }
}
