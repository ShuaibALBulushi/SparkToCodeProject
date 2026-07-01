namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Task 1:
             Declare variables to store a person's name (string), age (int), height in meters (double), and whether they are a
             student (bool). Assign them values directly in the code (no input needed), then print them as a single formatted info
             card.

             */

            string name = "Shuaib";
            int age = 24;
            double height = 173;
            bool student = false;

            Console.WriteLine("### Person's Info ###");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age + " years old");
            Console.WriteLine("Height: " + height + " meters");
            Console.WriteLine("Are you a Student? " + student);

            ///////////////////////////////////////////////////////////////////////////////////////



            //Task 2:Ask the user to enter the length and width of a rectangle as input, then calculate and display its area and perimeter.

            Console.Write("\nPlease Enter the Length of the regtangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Please Enter the Width of the regtangle: ");
            double width = double.Parse(Console.ReadLine());

            double Area = length * width;
            double Perimeter = 2 * (length + width);

            Console.WriteLine("The Area of the Rectangle = " + Area);
            Console.WriteLine("The Perimeter of the Rectangle = " + Perimeter);

            ///////////////////////////////////////////////////////////////////////////////////////



            // Task 3:Ask the user to enter a whole number, then determine whether it is even or odd and print the result

            Console.Write("\nPlease Enter the Number: ");
            int Num = int.Parse(Console.ReadLine());

            if (Num%2==0)
            {
                Console.WriteLine("Number " + Num + " is Even");
            }
            else
            {
                Console.WriteLine("Number " + Num + " is Odd");
            }

            ///////////////////////////////////////////////////////////////////////////////////////



            /*
             
            Task 4:
            Ask the user to enter their age and whether they hold a valid national ID (yes/no). Determine whether the person is
            eligible to vote.
            
            */

            Console.Write("\nPlease Enter your Age: ");
            int AgeCheck = int.Parse(Console.ReadLine());

            Console.Write("Do you have a valid national ID? ");
            bool ValidID = bool.Parse(Console.ReadLine());

            if(AgeCheck >= 18 && ValidID == true)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

            ///////////////////////////////////////////////////////////////////////////////////////


            /*
             Task 5:
             Ask the user to enter a single character representing a grade ('A', 'B', 'C', 'D', or 'F') and print the meaning of that
             grade using a switch-case statement.
             */

            Console.Write("\nPlease Enter your Grade: ");
            string Grade = Console.ReadLine();

            switch (Grade)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;

                case "B":
                    Console.WriteLine("Very Good");
                    break;

                case "C":
                    Console.WriteLine("Good");
                    break;

                case "D":
                    Console.WriteLine("Pass");
                    break;

                case "F":
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

            ///////////////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 6:
             Ask the user to enter a temperature in Celsius, convert it to Fahrenheit, then classify the weather based on the
             Celsius value

             */

            Console.Write("\nPlease Enter the tempreture in Celsius: ");
            int Celsius = int.Parse(Console.ReadLine());

            int Fahrenheit = (Celsius * 9 / 5) + 32;

            if(Celsius < 10)
            {
                Console.WriteLine("Tempretur in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("weather classification: Cold");
            }
            else if(Celsius >= 10 && Celsius <= 30) 
            {
                Console.WriteLine("Tempretur in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("weather classification: Mild");
            }
            else
            {
                Console.WriteLine("Tempretur in Fahrenheit: " + Fahrenheit);
                Console.WriteLine("weather classification: Hot");
            }

            ///////////////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 7:
             Ask the user to enter their age and calculate the ticket price based on the following age groups: 0-12, 13-59, and 60
             and above.

             */

            Console.Write("\nPlease Enter Your Age: ");
            int Age_Check = int.Parse(Console.ReadLine());

            if(Age_Check >= 0 && Age_Check <= 12) 
            {
                Console.WriteLine("Ticket Category: Children");
                Console.WriteLine("Ticket Price: 2 OMR");
            }
            else if(Age_Check >= 13 && Age_Check < 60)
            {
                Console.WriteLine("Ticket Category: Adults");
                Console.WriteLine("Ticket Price: 5 OMR");
            }
            else if(Age_Check >= 60)
            {
                Console.WriteLine("Ticket Category: Seniors");
                Console.WriteLine("Ticket Price: 3 OMR");
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }
        }
    }
}
