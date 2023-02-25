using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.DnaaToRna
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            char[] chars = dna.ToCharArray();
            for(int i = 0; i < dna.Length; i++)
            {
                if (chars[i] == 'T')
                {
                    chars[i] = 'U';
                }
            }

           dna=new string(chars);

            return dna;
        }
    }
}
