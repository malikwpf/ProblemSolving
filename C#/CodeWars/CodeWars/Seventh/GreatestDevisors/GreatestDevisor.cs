namespace CodeWars.Seventh.GreatestDevisors
{
    public class GreatestDevisor
    {
        public static int Gcd(int a, int b)
        {
            //int min = a < b ? a : b;
            //var devisor = 1;

            //for (int i = min; i >= 2; i--)
            //{
            //    if ((a % i == 0) && (b % i == 0))
            //    {
            //        devisor = i;
            //        break;
            //    }
            //}

            //return devisor;

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
