using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.PowerOf_2
{
    public class PowerOf_2Main
    {
        static void Main(string[] args)
        {
            var nums = PowerOf_2.PowersOfTwo(3);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
