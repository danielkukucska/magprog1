using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Sequential
{
    class Task_1_5 : ITask
    {
        const int PRICE_PER_STARTED_10_KM = 210;
        const double STUDENT_DISCOUNT_MULTIPLIER = 0.5;

        public void run()
        {
            Console.WriteLine($"This program will calculate the trip price for students.\n" +
                $"Price is 210 Ft for each started 10 km. The discount for stundents is {STUDENT_DISCOUNT_MULTIPLIER * 100}%.");

            int distance = this.getDistance();

            var price = Math.Round((Math.Ceiling(distance / 10.0) * PRICE_PER_STARTED_10_KM * STUDENT_DISCOUNT_MULTIPLIER) / 100, 0) * 100;

            Console.WriteLine($"The trip is {distance} km, the price is {price} Ft.");
        }

        private int getDistance()
        {
            int result;

            Console.Write($"distance (km): ");
            bool parsed = int.TryParse(Console.ReadLine(), out result);

            if (!parsed)
            {
                Console.WriteLine("Please provide an integer!");
                return this.getDistance();
            }

            return result;
        }
    }
}
