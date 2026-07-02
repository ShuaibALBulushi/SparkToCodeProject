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

            //////////////////////////////////////////////////////////////////////////



            /*
             
             Task 5:
             Fix a secret number in the code (for example, 42). Use a do-while loop to let the user keep guessing the number,
             printing "Too high" or "Too low" after each wrong guess. When the user guesses correctly, print how many attempts
             it took.

             */

            int attempt = 1;
            bool correctGuess = false;
            do
            {
                Console.WriteLine("\nguess the secret Number: ");
                int numGuess = int.Parse(Console.ReadLine());
                if(numGuess == 42)
                {
                    Console.WriteLine("The Number of attempts took to guess correctly: " + attempt);
                    correctGuess = true;
                }
                else if(numGuess > 42)
                {
                    Console.WriteLine("Too High");
                    attempt++;
                }
                else
                {
                    Console.WriteLine("Too Low");
                    attempt++;
                }

            }
            while(!correctGuess);

            //////////////////////////////////////////////////////////////////////////



            /*
             
             Task 6:
             Ask the user to enter two numbers and divide the first by the second, using try-catch to handle any errors safely.

             */
            try
            {
                Console.Write("\nplease Enter the first Number: ");
                int firstNum = int.Parse(Console.ReadLine());

                Console.Write("please Enter the second Number: ");
                int secondNum = int.Parse(Console.ReadLine());

                int res = firstNum / secondNum;
                Console.WriteLine("result = " + res);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("The second Number cannot be zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("input is not a valid number");
            }


        }
    }
}
