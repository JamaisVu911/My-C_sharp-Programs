using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Independent_work_7
{
    class Independent_work_7
    {
        static void Main(string[] args)
        {
            int n = 100, k, s;

            Console.WriteLine("Сумма 2 + 4 + 6 + .... + {0} = ", 2 * n);

            //while(k <= n) Вариант №1
            //{
            //s += n + 1;
            //k++;
            //}

            //do  Вариант №2
            //{
                //s += n + 1;
                //k++;
            //}

            //while (k <= n);

            for( k = 1, s = 0; k <= n; s += n + 1, k++); // Вариант №3

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
