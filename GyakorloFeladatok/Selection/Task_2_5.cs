using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Selection
{
    class Task_2_5 : ITask
    {
        public void run()
        {

            int maxScore = getMaxScore();

            int score = getScore(maxScore);

            float percent = (float)score / maxScore;

            Console.Write($"{percent * 100: 0.##} % --- grade: ");
            if (percent == 1f) Console.WriteLine("5*");
            else if (percent >= 0.8f) Console.WriteLine("5");
            else if (percent >= 0.7f) Console.WriteLine("4");
            else if (percent >= 0.6f) Console.WriteLine("3");
            else if (percent >= 0.5f) Console.WriteLine("2");
            else Console.WriteLine("1");

        }

        private int getMaxScore()
        {
            int result;

            Console.Write("Please provide max score: ");
            bool parsed = int.TryParse(Console.ReadLine(), out result);

            if (!parsed || result < 10 || result > 100)
            {
                Console.WriteLine("Please provide an integer between 10 and 100!");
                return this.getMaxScore();
            }

            return result;
        }

        private int getScore(int maxScore)
        {
            int result;

            Console.Write("Please provide your score: ");
            bool parsed = int.TryParse(Console.ReadLine(), out result);

            if (!parsed || result < 0 || result > maxScore)
            {
                Console.WriteLine($"Please provide an integer between 0 and {maxScore}!");
                return this.getScore(maxScore);
            }

            return result;
        }
    }
}
