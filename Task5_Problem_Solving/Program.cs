namespace Task5_Problem_Solving
{
    internal class Program
    {

        public static double CalculateAverage(List<int> grades)
        {
            return grades.Average();
        }

        public static int FindFirstFailing(List<int> grades)
        {
            return grades.Find(x => x < 60);
        }

        public static Queue<string> RemoveJob(Queue<string> queue, string jobName)
        {
            Queue<string> updatedQueue = new Queue<string>();
            while (queue.Count > 0)
            {
                string currentJob = queue.Dequeue();

                if (currentJob.ToLower() != jobName.ToLower())
                {
                    updatedQueue.Enqueue(currentJob);
                }
            }

            return updatedQueue;

        }

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

            //////////////////////////////////////////////////////



            /*
             Task 6:
             Create a List<string> for a shopping list. Use a while loop to let the user keep adding items until they type "done".
             Then ask for one item name to remove, use .Remove to take it out, and print the final list.
             */

            List<string> shoppingList = new List<string>();
            bool done = false;
            while (!done)
            {
                Console.Write("Enter an item for shopping list (or type 'done' to finish): ");
                string item = Console.ReadLine();
                if(item.ToLower() != "done")
                {
                    shoppingList.Add(item);
                }
                else
                {
                    done = true;
                }
       
            }
            Console.WriteLine("\nShopping list before item removal: " + string.Join(", ", shoppingList));

            Console.Write("\nEnter an item you want to remove: ");
            string itemToRemove = Console.ReadLine();

            shoppingList.Remove(itemToRemove);

            Console.WriteLine("Shopping list after item removal: " + string.Join(", ", shoppingList));

            //////////////////////////////////////////////////////



            /*
             Task 7:
             Ask the user to enter 5 game scores into a List<int>. Sort the list, then reverse it so the highest score comes first,
             and print the top 3 scores as a podium (1st, 2nd, 3rd place).
             */

            List<int> gameScores = new List<int>();
            
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter game score " + (i + 1) + ": ");
                gameScores.Add(int.Parse(Console.ReadLine()));
            }
            
            gameScores.Sort();
            gameScores.Reverse();
            string[] suffixes = { "1st", "2nd", "3rd" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(suffixes[i] + " place: " + gameScores[i]);
            }

            //////////////////////////////////////////////////////



            /*
             Task 8:
             Create a Stack<string> to track actions in a simple editor. Use a while loop to let the user keep typing actions (e.g.
             "typed a letter", "deleted a word") until they type "stop", pushing each one onto the stack. Afterward, simulate
             pressing "undo" twice by popping twice and printing each undone action, then print whatever remains on the stack
             using foreach
             */

            Stack<string> editorActions = new Stack<string>();

            bool stop = false;

            while (!stop)
            {
                Console.Write("Enter an action (or type 'stop' to finish): ");
                string action = Console.ReadLine();
                if (action.ToLower() != "stop")
                {
                    editorActions.Push(action);
                }
                else
                {
                    stop = true;
                }
            }

            Console.WriteLine("\n### Simulating Undo Twice ###");

            if (editorActions.Count >= 2)
            {
                string undoneAction1 = editorActions.Pop();
                Console.WriteLine("Undone action: " + undoneAction1);

                string undoneAction2 = editorActions.Pop();
                Console.WriteLine("Undone action: " + undoneAction2);
            }
            else
            {
                Console.WriteLine("Not enough actions in history to undo twice");
            }

            Console.WriteLine("\nRemaining actions in editor history:");

            foreach (string action in editorActions)
            {
                Console.WriteLine("- " + action);
            }

            //////////////////////////////////////////////////////



            /*
             Task 9:
             Ask the user how many grades they want to enter, then read that many grades into a List<int>. Write a function
             CalculateAverage that takes a List<int> as a parameter and returns the average as a double. Write a second
             function FindFirstFailing that takes a List<int> as a parameter and returns the first grade below 60, using the same
             Find-with-a-condition style shown in class (e.g. list.Find(x => x < 60)).
             */

            Console.WriteLine("Enter the number of grades you want: ");
            int numGrades = int.Parse(Console.ReadLine());

            List<int> gradesList = new List<int>();

            for(int i = 0; i < numGrades; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                gradesList.Add(int.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine("Average grade: " + CalculateAverage(gradesList));

            bool hasFailing = gradesList.Any(x => x < 60);

            if (hasFailing)
            {
                Console.WriteLine("First failing grade: " + FindFirstFailing(gradesList));
            }
            else
            {
                Console.WriteLine("No failing grades found.");
            }

            //////////////////////////////////////////////////////



            /*
             Task 10:
             Build a small print queue manager. Create a Queue<string> and use a while loop to let the user add print job names
             until they type "done". Then ask for the name of one job to cancel. Since Queue<T> has no direct way to remove an
             item by name, write a function called RemoveJob that takes the queue and the job name to remove as parameters,
             and returns an updated Queue<string> with that job taken out.
             */

            Queue<string> printQueue = new Queue<string>();

            bool hold = false;

            while(!hold)
            {
                Console.Write("Enter a print job name (or type 'done' to finish): ");
                string jobName = Console.ReadLine();
                if (jobName.ToLower() != "done")
                {
                    printQueue.Enqueue(jobName);
                }
                else
                {
                    hold = true;
                }
            }

            Console.WriteLine("\n### Print Queue Before Cancellation ###");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }

            Console.Write("\nEnter the name of the job you want to cancel: ");
            string jobToCancel = Console.ReadLine();

            printQueue = RemoveJob(printQueue, jobToCancel);

            Console.WriteLine("\n### Print Queue After Cancellation ###");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }
        }

    }
}
