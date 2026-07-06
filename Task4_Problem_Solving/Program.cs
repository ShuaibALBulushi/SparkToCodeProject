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

        //task 4 function:
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu options");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        //task 5 function:
        public static bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //task 6 function:
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        //task 7 function:
        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
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

            //////////////////////////////////////////


            //task 4:
            DisplayMenu();

            /////////////////////////////////////////


            //task 5:
            Console.Write("Enter the number: ");
            int num2 = int.Parse(Console.ReadLine());
            if(isEven(num2))
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }


            /////////////////////////////////////////


            //task 6:
            Console.Write("Enter the length: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of rectangle: " + CalculateArea(l, w));
            Console.WriteLine("Perimeter of rectangle: " + CalculatePerimeter(l, w));

            /////////////////////////////////////////


            //task 7:
            Console.Write("Enter the score: ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("your grade: " + GetGradeLetter(score));
        }
    }
}
