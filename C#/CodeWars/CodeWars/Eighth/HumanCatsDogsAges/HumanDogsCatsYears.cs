using System.Runtime.CompilerServices;

namespace CodeWars.Eighth.HumanCatsDogsAges
{
    public class HumanDogsCatsYears
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = 0;
            int dogYears = 0;

            for(int i = 0; i < humanYears; i++)
            {
                if (i == 0)
                {
                    catYears += 15;
                    dogYears += 15;
                }
                if(i== 1)
                {
                    catYears += 9;
                    dogYears += 9;
                }
                
                if(i!=0 && i != 1)
                {
                    catYears += 4;
                    dogYears += 5;
                }
            }

            return new int[] { humanYears, catYears, dogYears };
        }
    }
}
