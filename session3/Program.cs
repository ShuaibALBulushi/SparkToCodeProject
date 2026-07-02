namespace session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<string> fruits= ["apple", "banana", "cherry"];
            Console.WriteLine(fruits);

            for(int i = 0; i<=2; i++)
            {
                Console.WriteLine(fruits[i] + "fruit");
            }

            List<string> names = ["Ali", "Osama", "Salim"];
            Console.WriteLine(fruits);

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(names[i] + " is Omani");
            }
        }
    }
}

