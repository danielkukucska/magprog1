using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction();

            calculateTripCost();

            //calculateRequiredPaint();
        }

        static void introduction()
        {

            Console.Write("Enter your name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter your age: ");
            //int.Parse
            Console.ForegroundColor = ConsoleColor.Green;
            int age = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorVisible = false;

            Console.Clear();

            string outPut = $"Your name is {name} and you are {age} old and 10 years later you will be {age + 10} years old.";
            Console.SetCursorPosition(Console.WindowWidth / 2 - outPut.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(outPut);

            Console.ReadLine();
        }

        static void calculateTripCost()
        {
            Console.Write("Provide the car's consumption on 100 kilometers: ");
            double consumption = double.Parse(Console.ReadLine());

            Console.Write("Provide the trip length in kilometer: ");
            int tripLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Provide any additional fee: ");
            int additionalFee = Convert.ToInt32(Console.ReadLine());

            Console.Write("Provide the fuel cost: ");
            int fuelCost = Convert.ToInt32(Console.ReadLine());

            double totalCost = (tripLength / 100.0) * consumption * fuelCost + additionalFee;

            Console.WriteLine();
            Console.Write($"The trip will cost {totalCost:0.##}.");
            Console.ReadKey();
        }

        static void calculateRequiredPaint()
        {
            Console.Write("Provide the container's diameter in meter: ");
            double diameter = double.Parse(Console.ReadLine());

            Console.Write("Provide the container's height in meter: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Provide the paint's capacity/box in square meter: ");
            double capacity = double.Parse(Console.ReadLine());

            double A = 2 * diameter / 2 * Math.PI * (diameter / 2 + height);
            int boxCount = (int)Math.Ceiling(A / capacity);

            Console.Write($"You will need {boxCount} boxes.");

            Console.ReadKey();
        }
    }
}
