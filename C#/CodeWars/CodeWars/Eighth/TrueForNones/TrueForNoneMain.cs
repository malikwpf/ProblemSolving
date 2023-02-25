using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.TrueForNones
{
    public class TrueForNoneMain
    {
        public static void Main()
        {
            var output = TrueForNone.None(new int[] { 1, 2, 3, 4, 5 }
            , v => v > 4);

            Console.WriteLine(output);
        }
    }
}
