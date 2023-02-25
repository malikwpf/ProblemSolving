using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.CountSheep
{
    public class CountSheepMain
    {
        static void Main(string[] args)
        {
            bool[] arr ={true, true, true, false,
  true, true, true, true,
  true, false, true, false,
  true, false, false, true,
  true, true, true, true,
  false, false, true, true };

            Console.WriteLine(CountSheep.CountSheeps(arr));
        }
    }
}
