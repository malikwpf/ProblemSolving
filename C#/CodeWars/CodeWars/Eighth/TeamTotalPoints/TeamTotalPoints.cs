using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.TeamTotalPoints
{
    public class TeamTotalPoints
    {
        public static int TotalPoints(string[] games)
        {
            int OurScore=default;

            foreach(var game in games)
            {
              string[]GamseScore=  game.Split(new string[] { ":" }, StringSplitOptions.None);

                var thisGameOurPoints = Convert.ToInt32(GamseScore[0]);
                var thsiGameOppenentPoints = Convert.ToInt32(GamseScore[1]);

                if(thisGameOurPoints > thsiGameOppenentPoints)
                {
                    OurScore += 3;
                }
                else if(thisGameOurPoints < thsiGameOppenentPoints)
                {
                    OurScore += 0;
                }
                else
                {
                    OurScore++;
                }
            }

            return OurScore;
           
        }

        
    }
}
