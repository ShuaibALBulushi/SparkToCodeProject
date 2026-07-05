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

            if (name1.Trim().ToUpper() == name2.Trim().ToUpper())
            {
                Console.WriteLine("The two names are the same.");
            }
            else
            {
                Console.WriteLine("The two names are different.");
            }

            ///////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 8:
             Ask the user to enter their membership start date as text (e.g. "2026-01-10") and the number of valid membership
             days, then determine whether the membership is still active today.
            
            */

            try
            {
                Console.Write("\nEnter your membership start date (yyyy-MM-dd): ");
                DateTime startDateInput = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter the number of valid membership days: ");
                int validDays = int.Parse(Console.ReadLine());

                DateTime endDateMembership = startDateInput.AddDays(validDays);
                if (DateTime.Today <= endDateMembership)
                {
                    Console.WriteLine("Your membership is still active.");
                }
                else
                {
                    Console.WriteLine("Your membership has expired.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter the date in the format yyyy-MM-dd.");
            }

            ///////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 9:
             Ask the user to enter a decimal number, then print three different roundings of it: rounded to the nearest whole
             number, always rounded up, and always rounded down.
            
            */

            Console.Write("\nEnter a decimal number: ");
            double decimalNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Rounded to the nearest whole number: " + Math.Round(decimalNumber));
            Console.WriteLine("Always rounded up: " + Math.Ceiling(decimalNumber));
            Console.WriteLine("Always rounded down: " + Math.Floor(decimalNumber));

            ///////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 10:
             Ask the user to enter a full sentence and then a single word to search for. Find and print the position (index) where
             that word first appears inside the sentence, and also where it last appears (in case it occurs more than once).
            
            */

            Console.Write("\nEnter a full sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word to search for: ");
            string wordToSearch = Console.ReadLine();

            if (sentence.Contains(wordToSearch))
            {
                Console.WriteLine("The word " + wordToSearch + " first appears at index: " + sentence.IndexOf(wordToSearch));
                Console.WriteLine("The word " + wordToSearch + " last appears at index: " + sentence.LastIndexOf(wordToSearch));
            }
            else
            {
                Console.WriteLine("The word " + wordToSearch + " was not found in the sentence.");
            }

            ///////////////////////////////////////////////////////////////////////////////



            /*
             
             Task 11:
             Build a small OTP verification simulator. The program should generate a random 4-digit code (between 1000 and
             9999), display it once to simulate "sending" it, and then ask the user to type the code back to verify it.
            
            */

            Random random = new Random();
            int otp = random.Next(1000, 9999);
            Console.WriteLine("\nYour OTP code is " + otp);

            int attempts = 1;

            while (attempts <= 3)
            {
                try
                {
                    Console.Write("Enter the OTP code: ");
                    int userInput = int.Parse(Console.ReadLine());

                    if(userInput == otp) 
                    { 
                        Console.WriteLine("verified");
                        break;
                    }
                    else
                    {
                        if(attempts == 3)
                        {
                            Console.WriteLine("Incorrect OTP. You have exceeded the maximum number of attempts.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect OTP. Please try again.");
                        }
                        attempts++;
                    }
                
                }
                catch (FormatException)
                {
                    if (attempts == 3)
                    {
                        Console.WriteLine("Invalid input. You have exceeded the maximum number of attempts.");

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a 4-digit number.");
                    }
                    attempts++;
                }
            }

        }
    }
}