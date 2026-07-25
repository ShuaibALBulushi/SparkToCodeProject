using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EFCorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####    welcome     #####");

            //project contect object
            ProjectContext contect = new ProjectContext();

            bool stop = false;

            while (!stop)
            {
                Console.WriteLine("### Chose from following Options ###");
                Console.WriteLine("1. Add new (Employee or Department)");
                Console.WriteLine("2. Delete (Employee or Department)");
                Console.WriteLine("3. Update (Employee or Department)");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertNewObject(); break;

                    case "2":
                        DeleteObject(); break;

                    case "3":
                        UpdateObject(); break;

                    case "4":
                        stop = true;
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }


    }
}
