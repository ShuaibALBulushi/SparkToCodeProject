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
        }
    }
}
