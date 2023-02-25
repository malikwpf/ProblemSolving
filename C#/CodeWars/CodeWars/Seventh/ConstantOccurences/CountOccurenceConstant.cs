
namespace CodeWars.Seventh.ConstantOccurences
{
    public class CountOccurenceConstant
    {
        public static int ConsonantCount(string str)
        {
            var uprStr=str.ToUpperInvariant();
            var occurence = uprStr.Count(
                ch => ch == 'B' || ch == 'C' || ch == 'D' ||
                ch == 'F' || ch == 'G' || ch =='H' ||
                ch=='J' || ch=='K' || ch== 'L' ||
                ch=='M' || ch=='N' || ch=='P' ||
                ch=='Q' || ch=='R' || ch=='S' ||
                ch== 'T' || ch=='V' || ch=='W' ||
                ch=='X' || ch=='Y' || ch=='Z' );

            return occurence;
        }
    }
}
