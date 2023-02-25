
namespace CodeWars.Seventh.InterlockingBinary
{
    public class InterlockingBinaryPair
    {
        public static bool Interlockable(ulong a, ulong b)
        {
            var charA = Convert.ToString((long)a, 2).ToCharArray();
            var charB = Convert.ToString((long)b, 2).ToCharArray();

            
            var lengthA=charA.Length;
            var lengthB=charB.Length;
            var length = lengthA < lengthB ? lengthA : lengthB;

            for (int i = length-1; i >= 0; i--)
            {
                var temporaryLengthA=--lengthA;
                var temporaryLengthB=--lengthB;

                if (charA[temporaryLengthA] == '1' && charB[temporaryLengthB] == '1')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
