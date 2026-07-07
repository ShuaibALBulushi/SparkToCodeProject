namespace Task5_Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Task 1:
             Declare an array of 5 integers to store student grades. Use a for loop to ask the user to enter each grade and store it
             in the array, then use a foreach loop to print every grade.
             */

            int[] grades = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter the grade of student " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            foreach(int grade in grades)
            {
                Console.WriteLine("Grade: " + grade);
            }

            //////////////////////////////////////////////////////



            /*
             Task 2:
             Create a List<string> to store to-do items. Use a loop to ask the user to enter 5 tasks, adding each one to the list
             with .Add, then print the full list using foreach.
             */

            List<string> toDo = new List<string>();

            int taskCount = 5;

            for(int i = 0; i < taskCount; i++) 
            { 
                Console.Write("Enter task " + (i + 1) + ": ");
                toDo.Add(Console.ReadLine());
            }

            int taskNumber = 1;
            foreach (string task in toDo)
            {
                Console.WriteLine(taskNumber + ". " + task);
                taskNumber++;
            }

            //////////////////////////////////////////////////////



            /*
             Task 3:
             Create a Stack<string> to represent a browser's page history. Ask the user to enter 3 website URLs and Push each
             one onto the stack. Then simulate pressing the "back" button once by popping the stack and printing which page
             you land on.
             */

            Stack<string> browseHistory = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter website URL " + (i + 1) + ": ");
                string url = Console.ReadLine();
                browseHistory.Push(url);
            }

            Console.WriteLine("\n### Simulating Browser Back Button ###");
            Console.WriteLine("Current page: " + browseHistory.Peek());

            Console.Write("Do you want to go back (y/n)? ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                string removedPage = browseHistory.Pop();
                string previousPage = browseHistory.Peek();

                Console.WriteLine("You pressed the back button to leave " + removedPage);
                Console.WriteLine("Now you are on: " + previousPage);
            }
            else
            {
                Console.WriteLine("You chose not to go back. You are still on: " + browseHistory.Peek());
            }

            //////////////////////////////////////////////////////



            /*
             Task 4:
             Create a Queue<string> to represent customers waiting in line. Ask the user to enter 3 customer names and
             Enqueue each one. Then serve the first customer by dequeuing and printing their name.
             */

            Queue<string> customers = new Queue<string>();

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer waiting in line " + (i + 1) + ": ");
                customers.Enqueue(Console.ReadLine());
            }

            string srevedCustomer = customers.Dequeue();
            Console.WriteLine("Serving customer: " + srevedCustomer);

            //////////////////////////////////////////////////////



            /*
             Task 5:
             Ask the user to enter 5 grades into an int array using a loop. Sort the array with Array.Sort, then print the lowest
             grade, the highest grade, and the average of all 5 grades.
             */

            int[] grades1 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the grade of student " + (i + 1) + ": ");
                grades1[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades1);
            Console.WriteLine("Lowest grade: " + grades1[0]);
            Console.WriteLine("Highest grade: " + grades1[4]);

            double avg = grades1.Average();
            Console.WriteLine("Average grade: " + avg);
        }
    }
    
}
