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
        }
    }
}
