namespace Task3_Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task 1:
            Ask the user to enter two numbers, subtract the second from the first, and use a Math function to make sure the
            result is always displayed as a positive value, no matter the order entered.

             */

            Console.Write("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int val = num2 - num1;

            Console.WriteLine("Difference = " + Math.Abs(val));

            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 2:
            Ask the user to enter a number, then print its square (power of 2) and its square root.
             */

            Console.Write("\nEnter the number:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("square of number " + n + " = " + Math.Pow(n,2));
            Console.WriteLine("square root of number " + n + " = " + Math.Sqrt(n));
        }
    }
}
