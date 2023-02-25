using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.MeerkatsZoo
{
    public class My_HeadIsAtTheWrongEnd
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            foreach (var val in arr)
            {
                Console.Write(val);
            }
            Console.WriteLine();
            (arr[0], arr[2]) = (arr[2], arr[0]);
            foreach(var val in arr)
            {
                Console.Write(val);
            }
            return arr;
        }
    }
}
