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

            //////////////////////////////////////////////////////////////////////////



            /*
             
             Task 3:
             Ask the user to enter a number, then print its multiplication 
             table from 1 to 10 using a single for loop.

             */

            Console.Write("\nPlease Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }

            //////////////////////////////////////////////////////////////////////////



            /*
             
             Task 4:
             The correct password is fixed in the code as "Spark2026". Use a while loop to keep asking the user to enter the
             password until they type it correctly, then print "Access Granted".

             */

            bool correctpass = false;
            while (!correctpass)
            {
                Console.WriteLine("Please Enter your password: ");
                string pass = Console.ReadLine();
                if(pass == "Spark2026")
                {
                    Console.WriteLine("Access Granted");
                    correctpass = true;
                }
                else
                {
                    Console.WriteLine("Incorrect password, try again");
                }
            }
        }
    }
}
