using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.RemainderOFDivision
{
    public class RemainderOFDivision
    {
        public static int Remainder(int a, int b)
        {
            var max = Math.Max(a, b);
            var min=Math.Min(a, b);
            if (min!=0)
            return max%min;

            throw new DivideByZeroException();
        }
    }
}
