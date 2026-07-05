namespace session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(16));


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.AddDays(30));

            string word = "Hello World";
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.Length);
            Console.WriteLine(word.Substring(3,4));

        }
    }
}

