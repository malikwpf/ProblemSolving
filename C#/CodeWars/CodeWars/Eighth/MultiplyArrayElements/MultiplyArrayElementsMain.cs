using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.MultiplyArrayElements
{
    public class MultiplyArrayElementsMain
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            MultiplyArrayElements.Maps(arr);
            
            foreach (var i in arr)
                Console.WriteLine(i);
        }
    }
}
