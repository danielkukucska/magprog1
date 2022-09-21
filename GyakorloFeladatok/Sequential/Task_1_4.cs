using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_4: ITask
    {
         public void run()
        {
            Console.WriteLine("This program will convert a given angle to radian.");
            int angle = this.getAngle();

            double radian = angle * Math.PI / 180;

            Console.WriteLine($"The angle provided ({angle}) is {radian} in radian");
        }

        private int getAngle()
        {
            int result;

            Console.Write($"angle: ");
            bool parsed = int.TryParse(Console.ReadLine(), out result);

            if (!parsed)
            {
                Console.WriteLine("Please provide an integer!");
                return this.getAngle();
            }

            return result;
        }
    }
}
