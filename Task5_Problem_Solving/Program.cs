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
        }
    }
    
}
