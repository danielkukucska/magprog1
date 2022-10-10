using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeTasks.Sequential;
using PracticeTasks.Selection;

namespace PracticeTasks
{
    class Program
    {
        public static List<TaskAssociation> availableTasks = new List<TaskAssociation>();

        static void Main(string[] args)
        {
            inititalizeTasks();

            int taskIndex;
            string[] menuItems = availableTasks.Select(t => t.taskName).ToArray();
            do
            {
                taskIndex = ConsoleMenu.MultipleChoice(true, menuItems);
                if (taskIndex != -1) taskRunner(taskIndex);
            } while (taskIndex != -1);
        }

        static void inititalizeTasks()
        {
            availableTasks.Add(new TaskAssociation("1_3", new Task_1_3()));
            availableTasks.Add(new TaskAssociation("1_4", new Task_1_4()));
            availableTasks.Add(new TaskAssociation("1_5", new Task_1_5()));
            availableTasks.Add(new TaskAssociation("1_6", new Task_1_6()));
            availableTasks.Add(new TaskAssociation("1_7", new Task_1_7()));
            availableTasks.Add(new TaskAssociation("1_8", new Task_1_8()));
            availableTasks.Add(new TaskAssociation("1_9", new Task_1_9()));
            availableTasks.Add(new TaskAssociation("2_5", new Task_2_5()));
        }
        static void taskRunner(int taskIndex)
        {
            TaskAssociation task = null;
            try
            {
                task = availableTasks[taskIndex];
            }
            catch (Exception)
            {
                Console.WriteLine("Task not found.");
                Console.WriteLine("Press any key to clear console and show the menu.");
                Console.ReadKey();
            }
            if (task != null)
            {
                try
                {
                    task.solution.run();
                    Console.WriteLine("\nPress any key to clear console and show the menu.");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while running task: {task.taskName}");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to clear console and show the menu.");
                    Console.ReadKey();
                }
            }


        }
    }
}
