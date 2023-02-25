namespace CodeWars.Seventh.ReplaceOccurence
{
    public class ReplaceCoverage
    {
        public static string Covfefe(string tweet)
        {
            var oldSubStr = "coverage";
            var newSubStr = "covfefe";
            if (tweet.Contains(oldSubStr))
            {
                return tweet.Replace(oldSubStr,newSubStr);
            }
            return tweet + " " + newSubStr;
        }
    }
}
