using System.Text.RegularExpressions;

namespace CodeWars.Seventh.TimeCorrection
{
    public class CorrectTime
    {
        public static string Correct(string timeString)
        {
            if (string.IsNullOrEmpty(timeString))
            {
                return timeString;
            }

            Regex regExp = new Regex(@"(([0-9][0-9])):([0-9][0-9]):([0-9][0-9])");
            if (!regExp.IsMatch(timeString))
            {
                return null;
            }

            var hours = "";
            var minutes = "";
            var seconds = "";

            int i;
            for (i = 0; i < timeString.Length; i++)
            {
                if (timeString[i] == ':')
                {
                    break;
                }
                hours += timeString[i];
            }

            var minutesaver = i + 1;

            for (i = minutesaver; i < timeString.Trim().Length; i++)
            {
                if (timeString[i] == ':')
                {
                    break;
                }
                minutes += timeString[i];
            }

            var secondsaver = i + 1;

            for (i = secondsaver; i < timeString.Length; i++)
            {
                seconds += timeString[i];
            }

            int secondCount = 0;
            int minuteCount = 0;
            int hourCount = 0;

            var secondsInt = Convert.ToInt32(seconds);
            var minutesInt = Convert.ToInt32(minutes);
            var hoursInt = Convert.ToInt32(hours);

            while (true)
            {
                if (secondsInt < 60)
                {
                    break;
                }
                secondCount++;
                secondsInt -= 60;
            }

            minutesInt += secondCount;

            while (true)
            {
                if (minutesInt < 60)
                {
                    break;
                }
                minuteCount++;
                minutesInt -= 60;
            }

            hoursInt += minuteCount;

            while (true)
            {
                if (hoursInt < 24)
                {
                    break;
                }
                hourCount++;
                hoursInt -= 24;
            }

            if (hoursInt < 10)
            {
                hours = "0" + hoursInt;
            }
            else
            {
                hours = hoursInt.ToString();
            }
            if (minutesInt < 10)
            {
                minutes = "0" + minutesInt;
            }
            else
            {
                minutes = minutesInt.ToString();
            }
            if (secondsInt < 10)
            {
                seconds = "0" + secondsInt;
            }
            else
            {
                seconds = secondsInt.ToString();
            }

            return hours + ":" + minutes + ":" + seconds;

        }
    }
}
