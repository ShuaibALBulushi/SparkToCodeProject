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

            Console.WriteLine("square of number " + n + " = " + Math.Pow(n, 2));
            Console.WriteLine("square root of number " + n + " = " + Math.Sqrt(n));

            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 3:
             Ask the user to enter their full name, then print it in uppercase, in lowercase, and print how many characters it
             contains.             
            */

            Console.Write("\nEnter your full name:");
            string name = Console.ReadLine();

            Console.WriteLine("Lower case : " + name.ToLower());
            Console.WriteLine("Upper case : " + name.ToUpper());
            Console.WriteLine("Number of characters : " + name.Length);

            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 4:
             Ask the user to enter the number of days of a free trial, then calculate and print the date on which the trial ends,
             starting from today             
            */

            Console.Write("\nEnter the number of days:");
            int d = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(d);
            Console.WriteLine("Trial ends on: " + endDate.ToString("yyyy-MM-dd"));

            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 5:
             Ask the user to enter their raw exam score as a decimal number (e.g. 74.6), round it to the nearest whole number,
             then decide if they passed.             
            */

            Console.Write("\nEnter your exam score:");
            double exam = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(exam);

            if (roundedScore >= 60)
            {
                Console.WriteLine("You passed with a score of " + roundedScore);

            }
            else
            {
                Console.WriteLine("You failed with a score of " + roundedScore);
            }


            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 6:
             Ask the user to enter a password, then check whether it meets two basic conditions: it must be at least 8 characters
             long, and it must not contain the word "password" in it.             
            */

            Console.Write("\nEnter your password:");
            string pass = Console.ReadLine();

            if (pass.Length >= 8 && !pass.ToLower().Contains("password"))
            {
                Console.WriteLine("Password is strong because length is >= 8 and it doesnt contain word (password)");
            }
            else
            {
                Console.WriteLine("Password is week. It must be at least 8 characters long and not contain the word 'password'.");
            }

            ///////////////////////////////////////////////////////////////////////////////



            /*
             Task 7:
             Ask the user to enter the same name twice (once in each input), possibly typed with extra spaces or different casing,
             and check whether the two entries actually refer to the same name.            
            */


            Console.Write("\nEnter your name:");
            string name1 = Console.ReadLine();

            Console.Write("\nEnter your name again:");
            string name2 = Console.ReadLine();

            if(name1.Trim().ToUpper() == name2.Trim().ToUpper())
            {
                Console.WriteLine("The two names are the same.");
            }
            else
            {
                Console.WriteLine("The two names are different.");
            }
        }
    }

}
