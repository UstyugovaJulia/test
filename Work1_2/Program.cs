using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(100);
            var count = 1;

            Console.WriteLine($"Введите первое число");
            int k = Convert.ToInt32(Console.ReadLine());
            if (i == k)
            {
                Console.WriteLine("Успех!");
            }

            while (true)
            {
                int w = Math.Abs(i - k);

                count++;
                Console.WriteLine($"Введите {count} число");
                k = Convert.ToInt32(Console.ReadLine());
                if (i == k)
                {
                    Console.WriteLine("Успех!");
                    break;
                }

                int w1 = Math.Abs(i - k);
                if (w == w1)
                {
                    Console.WriteLine($" Вы вводили уже число {k}");
                    continue;
                }

                if (w > w1)
                {
                    Console.WriteLine("Горячо");
                    continue;
                }
                if (w < w1)
                {
                    Console.WriteLine("холодно");
                }
            }
        }
    }
}
