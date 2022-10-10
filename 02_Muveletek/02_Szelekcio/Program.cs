using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Muveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "KuKUcsKA dÁnEl";
            string neptunCode = "sQabSB";
            string password = "PASSWORD";

            Console.WriteLine(str.Contains("a"));
            Console.WriteLine(str.Contains("A"));

            Console.WriteLine(str.EndsWith("el"));
            Console.WriteLine(str.EndsWith("El"));

            Console.WriteLine(str.StartsWith("k"));
            Console.WriteLine(str.StartsWith("K"));

            Console.WriteLine(neptunCode.ToLower() == "sqabsb");
            Console.WriteLine(neptunCode.ToUpper() == "SQABSB");

            Console.WriteLine(str.Length);
            Console.WriteLine(str.PadLeft(60));
            Console.WriteLine(str.PadLeft(60, '.'));
            Console.WriteLine(str.PadRight(60));
            Console.WriteLine(str.PadRight(60, '.'));
            Console.WriteLine(str.PadRight(5, '.'));

            Console.WriteLine(password.Replace("A", "4").Replace("O", "0"));

            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(2, 5));

            Console.WriteLine("  a asd  sd  ".Trim());

            int a = 11;
            int b = 4;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(11.0 / 4);
            //Console.WriteLine((double)a / b);

            //Console.WriteLine(3594 %  10);
            //Console.WriteLine(3594 / 10 * 10);
            //Console.WriteLine(3594 / 100 * 100);
            //Console.WriteLine(3594 / 500 * 500);
            //Console.WriteLine(a % b);

            //Console.WriteLine((int)3.0);
            //Console.WriteLine((int)3.1);
            //Console.WriteLine((int)3.2);
            //Console.WriteLine((int)3.3);
            //Console.WriteLine((int)3.4);
            //Console.WriteLine((int)3.5);
            //Console.WriteLine((int)3.6);
            //Console.WriteLine((int)3.7);
            //Console.WriteLine((int)3.8);
            //Console.WriteLine((int)3.9);

            //Console.WriteLine(Convert.ToInt32(3.0));
            //Console.WriteLine(Convert.ToInt32(3.1));
            //Console.WriteLine(Convert.ToInt32(3.2));
            //Console.WriteLine(Convert.ToInt32(3.3));
            //Console.WriteLine(Convert.ToInt32(3.4));
            //Console.WriteLine(Convert.ToInt32(3.5));
            //Console.WriteLine(Convert.ToInt32(3.6));
            //Console.WriteLine(Convert.ToInt32(3.7));
            //Console.WriteLine(Convert.ToInt32(3.8));
            //Console.WriteLine(Convert.ToInt32(3.9));

            //a++;
            //a--;
            //a += 5;
            //a -= 4;
            //a *= 2;
            //a /= 3;
            //a %= 3;
             
            a = 11;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",
                a + 7 ,
                a*= 2,
                a-4,
                //first prin then increment
                a++,
                a+3,
                //first increment then increment
                ++a,
                a/=3,
                a*2,
                a--);
            Console.WriteLine(a);


            float c = 3.05f;
            Console.WriteLine(c += 0.02f);
            Console.WriteLine(c += 0.02f);
            Console.WriteLine(c += 0.02f);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(c += 0.02f);
            }

            double d = 3.05d;
            Console.WriteLine(d += 0.02d);
            Console.WriteLine(d += 0.02d);
            Console.WriteLine(d += 0.02d);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(d += 0.02f);
            }

            //Requires more memory but accurate
            decimal dec = 3.05m;
            Console.WriteLine(dec += 0.02m);
            Console.WriteLine(dec += 0.02m);
            Console.WriteLine(dec += 0.02m);
                                         
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(dec += 0.02m);
            }

            //double x = 1, y = 0, z = 0;

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c )/ (2 * a));
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c )/ (2 * a));

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.ReadLine();
        }
    }
}
