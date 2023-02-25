namespace CodeWars.Seventh.MinMaxMinArray
{
    public class TheSamllestBetween
    {
        public static int[] MinMinMax(int[] array)
        {
            var arrResult = new int[3];
            arrResult[0] = array.Min();
            arrResult[2] = array.Max();

            Array.Sort(arrResult);
            var neededValue = arrResult[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                
                if (array.Contains(++neededValue))
                {
                    continue;
                }
                else
                {
                    arrResult[1] = neededValue;
                    break;
                }
            }

            return arrResult;
        }
    }
}
