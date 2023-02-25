using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.TwiceOlder
{
    public class TwiceOlder
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            //if (dadYears - sonYears == sonYears)
            //    return 0;
            //else if (dadYears - sonYears > sonYears)
            //{
            //    var decide = true;
            //    int count = default;
            //    while (decide)
            //    {
            //        dadYears++;
            //        sonYears++;
            //        count++;
            //        if (dadYears - sonYears == sonYears)
            //        {
            //            decide = false;
            //        }

            //    }
            //    return count;
            //}

            //else
            //{
            //    var decide = true;
            //    int count = default;
            //    while (decide)
            //    {
            //        dadYears--;
            //        sonYears--;
            //        count++;
            //        if (dadYears - sonYears == sonYears)
            //        {
            //            decide = false;
            //        }
            //    }
            //    return count;
            //}

            return Math.Abs(dadYears - sonYears * 2);
        }
    }
}
