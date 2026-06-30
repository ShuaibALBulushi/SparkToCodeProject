namespace cSharpApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * this Project is to Learn and Practice C#
             
             */

            Console.WriteLine("### Spark To Code ###");

            //inputs
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your GPA: ");
            float gpa = float.Parse(Console.ReadLine());

            Console.WriteLine( "\n### Your Info ###\n"+
                               "Name: " + name + "\n" + 
                               "GPA: " + gpa + "\n" + 
                               "Age: " + age);

            //operations
            Console.WriteLine("### Operations ###");
            Console.WriteLine("Your Age after 4 Years: " + (age + 4));
            Console.WriteLine("Your Age before 4 Years was: " + (age - 4));

            Console.WriteLine("\n Enter x Value: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter y Value: ");
            int y = int.Parse(Console.ReadLine());

            int multplication = x * y;
            float division = x / y;
            float modulus = x % y;
            Console.WriteLine("x * y = " + multplication);
            Console.WriteLine("x / y = " + division);
            Console.WriteLine("x % y = " + modulus);


            //logical operations
            Console.WriteLine("is x greater than y: " + (x > y));
            Console.WriteLine("is x smaller than y: " + (x < y));
            Console.WriteLine("is x equal to y: " + (x == y));

            bool and = (x > y) && (x < y);
            bool or = (x > y) || (x < y);
            bool not = !(x > y);

            Console.WriteLine("AND Value: " + and);
            Console.WriteLine("OR Value: " + or);
            Console.WriteLine("NOT Value: " + not);


            //if statement
            Console.WriteLine("Enter your Degree: ");
            float degree = float.Parse(Console.ReadLine());
            if(degree < 50)
            {
                Console.WriteLine("your Grade: F");
            }

            else if(degree>50 && degree < 60)
            {
                Console.WriteLine("your Grade: D");
            }

            else if (degree > 60 && degree < 75)
            {
                Console.WriteLine("your Grade: C");
            }

            else if (degree > 75 && degree < 89)
            {
                Console.WriteLine("your Grade: B");
            }

            else if(degree > 89 && degree <= 100)
            {
                Console.WriteLine("your Grade: A");
            }
            else
            {
                Console.WriteLine("You Entered a wrong number...");
            }


            //switch
            Console.WriteLine("### Main Menu ###");
            Console.WriteLine("1.deposit\n2.withdraw\n3.balance");
            Console.WriteLine("Please choose from options above:");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Deposited");
                    break;
                case 2:
                    Console.WriteLine("withdrawed");
                    break;
                case 3:
                    Console.WriteLine("Your Balance is 200 OMR");
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }

        }
    }
}
