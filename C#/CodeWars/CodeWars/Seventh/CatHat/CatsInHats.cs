namespace CodeWars.Seventh.CatHat
{
    public class CatsInHats
    {
        public static string Height(int n)
        {
            var sum=0.000;
            var catUnits = 2000000.000;
            for (int i = 0; i <= n;i++)
            {
                sum+= catUnits;
                catUnits /= 2.500;
            }
            return sum.ToString("#.000");
        }
    }
}
