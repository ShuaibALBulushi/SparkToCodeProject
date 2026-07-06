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

        //task 8 function:
        public static void Countdown(int start)
        {
            for (int i = start; i>=1; i--)
            {
                Console.WriteLine(i);
            }
        }

        //task 9 function:
        public static int Multiply(int one, int two)
        {
            return one * two;
        }

        public static double Multiply(double one, double two)
        {
            return one * two;
        }

        public static int Multiply(int one, int two, int three)
        {
            return one * two * three;
        }

        //task 10 function:
        public static double CalculateArea(double side)
        {
            //square area
            return side * side;
        }

        //second function is in task 6, CalculateArea(double length, double width)


        //task 11 function:

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }

        public static double DivideNumbers(double a, double b)
        {
            try
            {
                double res = a / b;
                return res;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public static void DisplayResult(string operationName, double result)
        {
            Console.WriteLine("Result for " + operationName + ": " + result);
        }


        //task 12 function:
        public static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public static void PrintReportCard(string name, double average, string gradeLetter)
        {
            Console.WriteLine("### REPORT CARD ###");
            Console.WriteLine("Student Name: "+ name);
            Console.WriteLine("Final Average: " + average);
            Console.WriteLine("Letter Grade:  " + gradeLetter);
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

            /////////////////////////////////////////


            //task 8:
            Console.Write("Enter the start number for countdown: ");
            int startNum = int.Parse(Console.ReadLine());
            Countdown(startNum);

            /////////////////////////////////////////


            //task 9:
            Console.Write("Enter the first number: ");
            int fnum = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int snum = int.Parse(Console.ReadLine());

            Console.WriteLine("The product of the two integer numbers is: " + Multiply(fnum, snum));


            Console.Write("Enter the first number: ");
            double fnumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double snumber = double.Parse(Console.ReadLine());

            Console.WriteLine("The product of the two double numbers is: " + Multiply(fnumber, snumber));


            Console.Write("Enter the first number: ");
            int numOne = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numTwo = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int numThree = int.Parse(Console.ReadLine());

            Console.WriteLine("The product of the three integer numbers is: " + Multiply(numOne, numTwo, numThree));

            /////////////////////////////////////////


            //task 10:
            Console.WriteLine("Which shape do you want to calculate the area for?");
            Console.WriteLine("1) Square");
            Console.WriteLine("2) Rectangle");
            Console.Write("Enter choice (1 or 2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the side length of the square: ");
                double side = double.Parse(Console.ReadLine());

                double area = CalculateArea(side);
                Console.WriteLine("The area of the square is: " + area);
            }
            else if (choice == "2")
            {
                Console.Write("Enter the length of the rectangle: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());

                double area = CalculateArea(length, width);
                Console.WriteLine("The area of the rectangle is: " + area);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            /////////////////////////////////////////


            //task 11:
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("\n--- Simple Calculator Menu ---");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");
                Console.Write("Choose an option (1-5): ");

                string option = Console.ReadLine();

                if (option == "5")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting Calculator. Goodbye!");
                    break;
                }

                if (option == "1" || option == "2" || option == "3" || option == "4")
                {
                    try
                    {
                        Console.Write("Enter first number: ");
                        double number1 = double.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        double number2 = double.Parse(Console.ReadLine());

                        double result = 0;
                        string opName = "";

                        // FIXED: Changed 'choice' to 'option' so it matches your input variable
                        switch (option)
                        {
                            case "1":
                                result = Add(number1, number2);
                                opName = "Addition";
                                break;
                            case "2":
                                result = Subtract(number1, number2);
                                opName = "Subtraction";
                                break;
                            case "3":
                                result = MultiplyNumbers(number1, number2);
                                opName = "Multiplication";
                                break;
                            case "4":
                                result = DivideNumbers(number1, number2);
                                opName = "Division";
                                break;
                        }

                        // Call the required DisplayResult function
                        DisplayResult(opName, result);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter valid numeric values.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select an option between 1 and 5.");
                }
            }

            /////////////////////////////////////////////////////



            //task 12:
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter score for Subject 1: ");
            double s1 = double.Parse(Console.ReadLine());

            Console.Write("Enter score for Subject 2: ");
            double s2 = double.Parse(Console.ReadLine());

            Console.Write("Enter score for Subject 3: ");
            double s3 = double.Parse(Console.ReadLine());

            double avg = CalculateAverage(s1, s2, s3);

            string grade = GetGradeLetter(avg);

            PrintReportCard(studentName, avg, grade);
        }
    }
}
