using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_9 : ITask
    {
        public void run()
        {
            DateTime currentTime = DateTime.Now;
            int currentYear = currentTime.Year;
            DateTime christmasTime = new DateTime(currentYear, 12, 25, 00, 00, 00);
            TimeSpan difference = christmasTime - currentTime;

            Console.WriteLine($"This program shows the remaining nights until Christmas: {difference.Days} nights");
        }
    }
}
