namespace Task4_Problem_Solving
{
    internal class Program
    {

        //task 1 function:
        public static void PrintWelcome(string message) 
        {
            Console.WriteLine("Welcome to Spark to Code, " + message);
        }

        //task 2 function:
        public static int Square(int num1)
        {
            double res = Math.Pow(num1, 2);
            num1 = Convert.ToInt32(res);
            return num1;
        }

        //task 3 function:
        public static double CelsiusToFahrenheit(double celsius)
        {
            double res = (celsius * 9 / 5) + 32;
            return res;
        }

        static void Main(string[] args)
        {
            // task 1:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);

            //////////////////////////////////////////


            //task 2:
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The square of the number is: " + Square(num));

            //////////////////////////////////////////


            //task 3 :
            Console.Write("Enter tempreture in celsius: ");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Temprature in Fahrenheit: " + CelsiusToFahrenheit(temp));
        }
    }
}
