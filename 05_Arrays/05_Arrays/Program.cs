using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ATM();


            //int[] grades = { 1, 3, 4, 2, 2 };

            //double avg = grades.Average();

            //int gradesAboveAvg = 0;
            //Console.WriteLine("Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //    if (grade > avg)
            //        gradesAboveAvg++;
            //}

            //Console.WriteLine($"Average: {avg:0.00}");
            //Console.WriteLine($"Grades above average: {gradesAboveAvg}");

            //Console.ReadLine();

            //Random rnd = new Random();
            //int[] nums = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = rnd.Next(100);
            //}
            //Console.WriteLine(string.Join(", ", nums));

            //string str = "test text";
            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);

            ////string(charArray)
            //Console.WriteLine(charArray);

            CreateDistincArray();
        }

        static void ATM()
        {
            int[] denominations = new int[] { 20000, 10000, 5000, 2000, 1000, 500 };
            int[] outOfStockDenominations = new int[] { 1000, 2000 };
            Console.Write("Amount: ");
            int amount = int.Parse(Console.ReadLine());

            foreach (int denomiation in denominations)
            {
                if (outOfStockDenominations.Contains(denomiation))
                    continue;

                int count = amount / denomiation;
                if (count > 0)
                {
                    Console.WriteLine($"{count} * {denomiation} Ft");
                    amount -= count * denomiation;
                }
            }

            Console.ReadLine();
        }

        static void CreateDistincArray()
        {
            int[] nums = new int[100];

            int index = 0;
            Random rnd = new Random();
            while (index < nums.Length)
            {
                int num = rnd.Next(100);

                bool exists = false;
                for (int i = 0; i < index; i++)
                {
                    if (nums[i] == num)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    nums[index] = num;
                    index++;
                }
            }

            Console.WriteLine(string.Join(", ",nums));
        }
    }
}
