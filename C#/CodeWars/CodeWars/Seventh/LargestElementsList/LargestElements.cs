using System.Linq;
namespace CodeWars.Seventh.LargestElementsList
{
    public class LargestElements
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < n; i++)
            {
                result.Add(xs.Max());
                xs.Remove(xs.Max());
            }

            result.Sort();

            //To view the output
            //foreach (var res in result)
            //{
            //    Console.Write(res+" ");
            //}

            

            return result;
        }
    }
}
