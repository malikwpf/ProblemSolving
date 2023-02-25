using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.CheckXO_Occurence
{
    public class CheckXO_Occurences
    {
        public static bool XO(string input)
        {
            //var CountX=input.Count(x=>char.ToUpperInvariant(x)==char.ToUpperInvariant('x'));
            //var CountO=input.Count(x=>char.ToUpperInvariant(x)==char.ToUpperInvariant('o'));

            //if (CountX == CountO)
            //    return true;
            //return false;

            return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');

        }
    }
}
