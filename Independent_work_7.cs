using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Independent_work_7
{
    class Independent_work_7
    {
        static void Main(string[] args)
        {
            int n = 100, k = 1, s = 0;

            Console.WriteLine("Сумма 2 + 4 + 6 + .... + {0} = ", 2 * n);

            while(k <= n)
            {
                s += n + 1;
                k++;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
