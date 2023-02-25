namespace CodeWars.Seventh.SuMOfASCIIS
{
    public class StringSum
    {
        public static int UniTotal(string str)
        {
            var sum=0;
            foreach(var c in str)
            {
                sum+=Convert.ToInt32(c);
            }
            return sum;
        }
    }
}
