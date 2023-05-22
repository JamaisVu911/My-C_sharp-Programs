using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Independent_work_11
{
    class Independent_work_11
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int numbertwo;
            int number = 1;
            //int i = 0; При Варианте №1 или №2

            try
            {
                Console.WriteLine("Введите первое число: ");
                numbertwo = Int32.Parse(Console.ReadLine());

                /* Вариант №1
                while (i  <= numbertwo)
                {

                    while(number % 5 == 2 || number % 3 == 1)
                    {

                        Console.Write(number + " + ");
                        sum += number;
                        number++;

                    }
                    number++;
                    i++;              
                }
                */

                /* Вариант №2
                do
                {
                    while (number % 5 == 2 || number % 3 == 1)
                    {
                        Console.Write(number + " + ");
                        sum += number;
                        number++;
                    }
                    number++;
                    i++;
                }
                while (i <= numbertwo);
                */

                // Вариант №3
                for( int i = 0; i <= numbertwo; i++)
                {
                    while (number % 5 == 2 || number % 3 == 1)
                    {
                        Console.Write(number + " + ");
                        sum += number;
                        number++;
                    }
                    number++;
                }

            }
            catch
            {
                Console.WriteLine("Введено не число!!!");
            }
            Console.Write(" = " + sum);
            Console.ReadKey();
        }
    }
}
