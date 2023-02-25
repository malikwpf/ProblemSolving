using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.CountSheep
{
    public class CountSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int totalCount = sheeps.Count(x => x == true);

            return totalCount;
        }
    }
}
