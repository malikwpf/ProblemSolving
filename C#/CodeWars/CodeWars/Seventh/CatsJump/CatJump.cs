namespace CodeWars.Seventh.CatsJump
{
    public class CatJump
    {
        static int jumps = 0;
        public static int Cats(int start, int finish)
        {
            if(finish - start is 0)
            {
                return jumps;
            }

            else if (finish - start is 1)
            {
                jumps++;
                return jumps;
            }

            else if (finish-start is 2)
            {
                jumps += 2;
                return jumps;
            }

            else if (finish - start is 3)
            {
                jumps++;
                return jumps;
            }

            else
            {
                start = start + 3;
                jumps++;
                return Cats(start, finish);
            }
        }
    }
}
