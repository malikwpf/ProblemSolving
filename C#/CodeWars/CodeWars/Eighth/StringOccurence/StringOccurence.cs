using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.StringOccurence
{
    public class StringOccurence
    {

        //You can use both

        //Be aware with lambda convert after definition not before
        public static int StrCount(string str, string letter) {

            //return str.Split(new[] { letter }, StringSplitOptions.None).Length-1;

            return str.Count(f=>f.ToString()==letter);
        }
    }
}
