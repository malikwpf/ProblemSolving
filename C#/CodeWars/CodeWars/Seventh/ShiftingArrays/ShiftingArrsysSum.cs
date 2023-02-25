namespace CodeWars.Seventh.ShiftingArrays
{
    internal class ShiftingArrsysSum
    {
        public static int[] AddingShifted(int[][] arrayOfArrays, int shift)
        {
            var length = ((arrayOfArrays.Length-1) * shift) + arrayOfArrays[0].Length;
            var arrs = new int[arrayOfArrays.Length,length];
            var arr = new int[length];
            int flag = 0;

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                for (int j = 0; j < arrayOfArrays[0].Length; j++)
                {
                    arrs[i, j + flag] = arrayOfArrays[i][j];

                }
                flag += shift;
            }

            for(int j = 0; j < length; j++)
            {
                for(int i = 0; i < arrayOfArrays.Length; i++)
                {
                    arr[j]+=arrs[i, j];
                }
            }

            //For display
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            return arr;
        }
    }
}
