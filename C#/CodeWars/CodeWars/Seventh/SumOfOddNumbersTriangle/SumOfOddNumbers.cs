namespace CodeWars.Seventh.SumOfOddNumbersTriangle
{
    public class SumOfOddNumbers
    {
        public static long RowSumOddNumbers(long n)
        {
            int numbersToSkip = 0;
            var oddNumbersList = new List<int>();
            var neededList=new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbersToSkip += i;
            }

            for (int i = 1; i <2*numbersToSkip; i+=2)
            {
                oddNumbersList.Add(i);
            }

            neededList = oddNumbersList.Skip(numbersToSkip - (int)n).Take((int)n).ToList();
            return neededList.AsQueryable().Sum();
        }
    }
}
