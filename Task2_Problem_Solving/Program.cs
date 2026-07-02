namespace Task2_Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Task 1:
             Ask the user to enter a starting number, then print a countdown from that number down to 1 using a for loop, and
             print "Liftoff!" after the loop ends.

             */

            Console.Write("Please Enter the starting Number: ");
            int snum = int.Parse(Console.ReadLine());
            
            for(int i = snum; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

            //////////////////////////////////////////////////////////////////////////



            /*
             
             Task 2:
             Ask the user to enter a positive whole number N, then use a for loop to calculate the sum of all whole numbers from
             1 to N, and print the final sum.

             */

            Console.Write("\nPlease Enter positive whole number: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 1; i<=N; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of All Numbers = " + sum);
        }
    }
}
