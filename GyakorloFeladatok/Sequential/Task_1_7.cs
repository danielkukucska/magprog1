using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_7 : ITask
    {
        public void run()
        {
            DateTime currentTime = DateTime.Now ;
            int currentYear = currentTime.Year;
            DateTime christmasTime = new DateTime(currentYear,12,25, 00,00,00);
 
            Console.WriteLine($"This program shows the remaining time until Christmas: {christmasTime.Month - currentTime.Month} months, {christmasTime.Day - currentTime.Day} days, {christmasTime.Hour - currentTime.Hour} hours, {christmasTime.Minute - currentTime.Minute} minutes");
        }
    }
}
