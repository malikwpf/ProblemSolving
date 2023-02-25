namespace CodeWars.Eighth.DnaaToRna
{
    public class Program
    {
        static void Main(string[] args)
        {
            Converter _converter = new Converter();
            Console.WriteLine(_converter.dnaToRna("GCTT"));
        }
    }
}
