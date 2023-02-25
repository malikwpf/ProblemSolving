using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.FindMultiples
{
    public class Multiples
    {
        public static List<int> FindMultiples(int integer, int limit)
        {
            var divisionCOutCome = (limit / integer);  
            var multipleslist=new List<int>();
            var up=integer;

            multipleslist.Add(integer);
            for(int i = 1; i < divisionCOutCome; i++)
            {
                integer += up;
                multipleslist.Add(integer);  
            }
            return multipleslist;
        }
    }
}
