using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.OnlyOne
{
    public class OnlyOneObject
    {
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }
}
