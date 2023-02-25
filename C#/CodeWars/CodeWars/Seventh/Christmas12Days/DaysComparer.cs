namespace CodeWars.Seventh.Christmas12Days
{
    public class DaysComparer : IComparer<string>
    {
        IDictionary<string, string> songLines = new Dictionary<string, string>()
            {
                {"24","On the 12th day of Christmas my true love gave to me" },
                {"23","On the 11th day of Christmas my true love gave to me" },
                {"22","On the 10th day of Christmas my true love gave to me" },
                {"21","On the 9th day of Christmas my true love gave to me" },
                {"20","On the 8th day of Christmas my true love gave to me" },
                {"19","On the 7th day of Christmas my true love gave to me" },
                {"18","On the 6th day of Christmas my true love gave to me" },
                {"17","On the 5th day of Christmas my true love gave to me" },
                {"16","On the 4th day of Christmas my true love gave to me" },
                {"15","On the 3rd day of Christmas my true love gave to me" },
                {"14","On the 2nd day of Christmas my true love gave to me" },
                {"13","On the 1st day of Christmas my true love gave to me" },
                {"12","12 drummers drumming," },
                {"11","11 pipers piping,"},
                {"10","10 lords a leaping," },
                {"9","9 ladies dancing," },
                {"8","8 maids a milking," },
                {"7","7 swans a swimming," },
                {"6","6 geese a laying," },
                {"5","5 golden rings," },
                {"4","4 calling birds," },
                {"3","3 French hens," },
                {"2","2 turtle doves and" },
                {"1","a partridge in a pear tree." }
            };

        public int Compare(string line1, string line2)
        {
            line1 = songLines.Values.ToList().IndexOf(line1).ToString();
            line2 = songLines.Values.ToList().IndexOf(line2).ToString();

            return Convert.ToInt32(line1).CompareTo(Convert.ToInt32(line2));
        }
    }
}
