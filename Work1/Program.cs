using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(100);
            var count = 1;

            while (true)
            {
                //Console.WriteLine("Введите " + count + " число:"); //или
                Console.WriteLine($"Введите {count} число");
                count++;
                int k = Convert.ToInt32(Console.ReadLine());

                if (i == k)
                {
                    Console.WriteLine("Успех");
                    break;
                }

                if (i > k)
                {
                    Console.WriteLine("Горячо");
                }

                if (i < k)
                {
                    Console.WriteLine("Холодно");
                }

            }
        }
    }
}
