using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Eighth.TeamTotalPoints
{
    public class TeamTotalPointsMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TeamTotalPoints.TotalPoints(new[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }));
        }
    }
}
