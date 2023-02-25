using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.AdditiveInverse
{
    public class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            //for(int i = 0; i < input.Length; i++)
            //{
            //    input[i] = -input[i];
            //}
            //return input;

            return input.Select(x => -x).ToArray();
        }
    }
}
