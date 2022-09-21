using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_6 : ITask
    {
        public void run()
        {
            Console.WriteLine("This program will calculate the expiry date of vaccination.");

            DateTime dateOfVaccination = this.getDate();

            Console.WriteLine($"You got vaccinated on: {dateOfVaccination:yyyy.MM.dd.} and will exprie on {dateOfVaccination.AddDays(182):yyyy.MM.dd.}");
        }

        private DateTime getDate()
        {
            DateTime result;

            Console.Write($"date (yyyy.MM.dd): ");
            bool parsed = DateTime.TryParseExact(Console.ReadLine(), "yyyy.MM.dd", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result);

            if (!parsed)
            {
                Console.WriteLine("Please provide date with 'yyyy-MM-dd' format !");
                return this.getDate();
            }

            return result;
        }

    }
}
