namespace Task4_Problem_Solving
{
    internal class Program
    {

        //task 1 function:
        public static void PrintWelcome(string message) 
        {
            Console.WriteLine("Welcome to Spark to Code, " + message);
        }

       

        static void Main(string[] args)
        {
            // task 1:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);

            //////////////////////////////////////////


            
        }
    }
}
