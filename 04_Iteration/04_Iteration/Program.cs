using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 29 || num % 7 != 0)
            {
                Console.WriteLine(num);
                num++;
            }

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            for (int i = 2; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i * i);
            }

            for (double i = 3.04; i < 12.6547; i += 0.03)
            {
                Console.WriteLine(i);
            }

            int a;
            do
            {
                Console.Write("Provide a whole number in range of [10;20): ");
            } while (!int.TryParse(Console.ReadLine(), out a) || a < 10 || a >= 20);

            Console.WriteLine(a);

            bool b = false;
            Console.WriteLine("Value of variable is {0}", b ? "TRUE" : "FALSE");

            int sum = 0, prod = 1, min = int.MaxValue, max = int.MinValue;
            bool isAnyEven = false;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. number:", i);
                int szam = int.Parse(Console.ReadLine());
                sum += szam;
                prod *= szam;
                if (szam < min)
                    min = szam;
                if (szam > max)
                    max = szam;
                if (szam % 2 == 0)
                    isAnyEven = true;
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Product: {0}", prod);
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Is there any even: {0}", isAnyEven ? "yes" : "no");


            int songsCount;
            do
            {
                Console.Write("Coung of songs: ");
            } while (!int.TryParse(Console.ReadLine(), out songsCount) || songsCount < 1);


            int sumLength = 0;
            for (int i = 1; i <= songsCount; i++)
            {
                Console.WriteLine("Length of song {0}", i);

                int minutes;
                do
                {
                    Console.Write("Minutes: ");
                } while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0);

                int seconds;
                do
                {
                    Console.Write("Seconds: ");
                } while (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 0 || seconds > 59);

                int songLength = minutes * 60 + seconds;
                sumLength += songLength;
            }

            int sumHours = sumLength / 3600;
            sumLength -= sumHours * 3600;
            int sumMinutes = sumLength / 60;
            sumLength -= sumMinutes * 60;
            int sumSeconds = sumLength;

            Console.WriteLine("The album's length is {0} hours, {1:00} minutes, {2:00} seconds", sumHours, sumMinutes, sumSeconds);
            Console.ReadLine();
        }
    }
}
