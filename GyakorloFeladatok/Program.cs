using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeTasks.Sequential;

namespace PracticeTasks
{
    class Program
    {
        public static List<TaskAssociation> availableTasks = new List<TaskAssociation>();

        static void Main(string[] args)
        {
            inititalizeTasks();

            string task;
            do
            {
                Console.Write("Please select a task or type 'exit' to quit: ");
                task = Console.ReadLine();
                if (task != "exit") taskRunner(task);
            } while (task != "exit");
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

            Console.WriteLine("Available tasks:");
            availableTasks.ForEach(task =>
            {
                Console.WriteLine(task.taskName);
            });
        }
        static void taskRunner(string taskName)
        {
            TaskAssociation task = availableTasks.Find(x => x.taskName == taskName);
            if (task == null)
            {
                Console.WriteLine($"No task found: {taskName}");
            }
            else
            {
                try
                {
                task.solution.run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while running task: {taskName}");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
