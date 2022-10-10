using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Szelekcio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");

            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is even", a);
            }
            else
            {
                Console.WriteLine("{0} is odd", a);
            }

            if (a > 0)
            {

            }
            else if (a < 0)
            {

            }
            else
            {

            }

            Console.Write("b= ");

            int b;
            if (int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
            }

            //[4; 9)
            Console.Write("c = ");
            int c = 3;

            if(c >= 4 && c < 9)
            {

            }
            else
            {

            }
            Console.ReadLine();
        }
    }
}
