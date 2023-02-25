namespace CodeWars.Seventh.Squares
{
    internal class IsSquareNumber
    {
        public static bool IsSquare(int n)
        {
            var root = Math.Sqrt(n);
            if(root == (int)root)
                return true;
            return false;
        }
    }
}
