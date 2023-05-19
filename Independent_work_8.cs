using System;


namespace Independent_work_8
{
    class Independent_work_8
    {
        static void Main(string[] args)
        {

            int n = 10, k, s;

            Console.WriteLine("Сумма 1 * 1 + 2 * 2 + 3 * 3 + .... + {0} = ", n * n);

            //while(k <= n) Вариант №1
            //{
            //s += k * k;
            //k++;
            //}

            //do  Вариант №2
            //{
            //s += k * k;
            //k++;
            //}

            //while (k <= n);

            for (k = 1, s = 0; k <= n; s += k * k, k++) ; // Вариант №3

            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
