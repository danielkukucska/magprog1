using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_3 : ITask
    {
        public static string taskName = "3_1";

        public void run(){
            Console.WriteLine("Please provide the coordinates of two points and the program will calculate the distance between them.");

            int x0 = this.getCoordinate("x0");

            int y0 = this.getCoordinate("y0");

            int x1 = this.getCoordinate("x1");

            int y1 = this.getCoordinate("y1");

            double distance = Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));

            Console.WriteLine($"The distance between A({x0},{y0}) and B({x1},{y1}) is {distance:0.00}.");
        }
        private int getCoordinate(string point)
        {
            int result;

            Console.Write($"{point}: ");
            bool parsed = int.TryParse(Console.ReadLine(), out result);

            if (!parsed)
            {
                Console.WriteLine("Please provide an integer!");
                return this.getCoordinate(point);
            }

            return result;
        }
    }
}
