using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Randoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //always one initialization
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
                //[0;int.MaxValue)
                Console.WriteLine(random.Next());

                //[0;100)
                Console.WriteLine(random.Next(100));

                //[-10;100)
                Console.WriteLine(random.Next(-10,100));

                //[-10;100) even numbers
                Console.WriteLine(random.Next(-5, 50)*2);

                //[3;20) .000
                Console.WriteLine(random.Next(3*1000, 20*1000)/1000.0);

                //[0;1)
                Console.WriteLine(random.NextDouble());

                //[3;20) double
                //Math.Round
                Console.WriteLine(random.NextDouble() * (20 - 3) +3);
            //}
        }
    }
}
