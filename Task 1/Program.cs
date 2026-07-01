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
        }
    }
}
