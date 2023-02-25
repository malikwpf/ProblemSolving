using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.TrafficLights
{
    public class TrafficLight
    {
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green": current = "yellow";break;
                case "yellow": current = "red";break;
                case "red": current = "green";break;
            }
            return current;

        }
    }
}
