using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EFCorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####    welcome     #####");
            

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
                        DeleteTableData(); break;

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

        public static void InsertNewObject()
        {
            ProjectContext context = new ProjectContext();
            Console.WriteLine("Enter 1 if you want to add employee\nEnter 2 if you want to add department: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Employee e1 = new Employee();
                Console.WriteLine("Enter SSN: ");
                e1.Ssn = Console.ReadLine();

                Console.WriteLine("Enter name: ");
                e1.EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter gender: ");
                e1.EmployeeSex = Console.ReadLine();

                Console.WriteLine("Enter salary: ");
                e1.EmplyeeSalary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Address: ");
                e1.EmployeeAddress = Console.ReadLine();

                Console.WriteLine("Enter Birth date: ");
                e1.EmployeeBDate = Console.ReadLine();

                context.employees.Add(e1);
                context.SaveChanges();

            }
            else if(choice == "2")
            {
                Department d1 = new Department();

                Console.WriteLine("Enter name: ");
                d1.DepartmentName = Console.ReadLine();

                Console.WriteLine("Enter number: ");
                d1.DepartmentNumber = int.Parse(Console.ReadLine());

                context.departments.Add(d1);
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }

        public static void DeleteTableData()
        {
            ProjectContext context = new ProjectContext();
            Console.WriteLine("Enter 1 if you want to delete employee\nEnter 2 if you want to delete department: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter employee id you want to delete: ");
                int id = int.Parse(Console.ReadLine());

                Employee emp = context.employees.FirstOrDefault(e => e.EmployeeId == id);

                if (emp != null)
                {
                    context.employees.Remove(emp);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("no employee found with this id");
                }

            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter department id you want to delete: ");
                int id = int.Parse(Console.ReadLine());

                Department dp = context.departments.FirstOrDefault(d => d.DepartmentId == id);

                if (dp != null)
                {
                    context.departments.Remove(dp);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("no department found with this id");
                }
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
