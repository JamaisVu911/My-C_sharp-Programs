using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_9
{
    class Independent_work_9
    {
        static void Main(string[] args)
        {
            int kone = 1;
            int ktwo = 1;
            int sum;

            int n;
            Console.Write("Введите количество чисел в последовательности Фибоначчи: ");
            n = Int32.Parse(Console.ReadLine());
            int s;
            
            Console.Write(kone + " , " + ktwo);

            /* Вариант №1
            while (s < (n - 2))
            {
                sum = kone + ktwo;
                kone = ktwo;
                ktwo = sum;
                s++;
                Console.Write(" , " + sum);
            }
            */
            
            /* Вариант №2
            do
            {
                sum = kone + ktwo;
                kone = ktwo;
                ktwo = sum;
                s++;
                Console.Write(" , " + sum);

            }
            while (s < (n - 2));
            */

            // Вариант №3

            for(s = 0; s < (n - 2); s++ )
            {
                sum = kone + ktwo;
                kone = ktwo;
                ktwo = sum;
                Console.Write(" , " + sum);
            }

            Console.ReadKey();
        }
    }
}
