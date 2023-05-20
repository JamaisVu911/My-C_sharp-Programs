using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_10
{
    class Independent_work_10
    {
        static void Main(string[] args)
        {
            int numberone, numbertwo, numberMAX, numberMin;
            

            try
            {
                Console.WriteLine("Введите первое число: ");
                numberone = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                numbertwo = Int32.Parse(Console.ReadLine());

                if (numberone > numbertwo)
                {
                    numberMAX = numberone;
                    numberMin = numbertwo;
                }
                else
                {
                    numberMAX = numbertwo;
                    numberMin = numberone;
                }

                Console.Write(numberMin + " , ");

                // int subsequence = numberMin + 1; // Вариант №1 и №2

                /* Вариант №1
                 
                while (subsequence < numberMAX)
                {
                    Console.Write(subsequence + " , ");
                    subsequence++;
                }

                */

                /* Вариант №2
                do
                {
                    Console.Write(subsequence + " , ");
                    subsequence++;
                }
                while (subsequence < numberMAX);

                */

                for(int subsequence = numberMin + 1; subsequence < numberMAX; subsequence++)
                {
                    Console.Write(subsequence + " , ");
                }

                Console.Write(numberMAX);

            }
            catch
            {
                Console.WriteLine("Введено не число!!!");
            }
            Console.ReadKey();
        }
    }
}
