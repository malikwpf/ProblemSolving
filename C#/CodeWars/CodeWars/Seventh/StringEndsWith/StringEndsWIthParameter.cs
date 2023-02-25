namespace CodeWars.Seventh.StringEndsWith
{
    public class StringEndsWIthParameter
    {
        public static bool Solution(string str, string ending)
        {
            if (str.Length < ending.Length) { return false; }
            if(ending is "") { return true; }
            if(str == ending) { return true; }

            var subStr = str[^(ending.Length)..];

            if(subStr==ending) { return true; }
            return false;
        }
    }
}
