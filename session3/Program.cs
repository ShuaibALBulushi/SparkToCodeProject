namespace session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<string> fruits= ["apple", "banana", "cherry"];
            Console.WriteLine(fruits);

            for(int j = 0; j<=2; j++)
            {
                Console.WriteLine(fruits[j] + " fruit");
            }

            List<string> names = ["Ali", "Osama", "Salim"];

           
            int i = 0;
            while(i<=names.Count()-1)
            {
                Console.WriteLine(names[i] + " is Omani");
                i++;
            }
        }
    }
}

