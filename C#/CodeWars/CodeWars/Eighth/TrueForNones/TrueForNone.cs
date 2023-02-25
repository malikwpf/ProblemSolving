using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.TrueForNones
{
    public class TrueForNone
    {
        public static bool None(int[] arr, Func<int, bool> fun)
        {
            //if(arr is null || arr.Length == 0)
            //{
            //    return true;
            //}
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (fun(arr[i]) == true)
            //    {
            //        return false;
            //    }
            //}
            //return true;

            return !arr.Any(fun);
        }
    }
}
