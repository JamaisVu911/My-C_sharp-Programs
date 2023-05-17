using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Independent_work_3
{
    class Independent_work_3
    {
        static void Main(string[] args)
        {

            int numberOne, numberTwo, numberThree, resultOne;

            try
            {
                numberOne = Int32.Parse(Interaction.InputBox("Введите первое число", "Первое число"));
                numberTwo = Int32.Parse(Interaction.InputBox("Введите второе число", "Второе число"));

                resultOne = numberOne + numberTwo;
                string txt = "Сумма двух чисел равна: " + resultOne;
                MessageBox.Show(txt);

                do
                {
                    numberThree = Int32.Parse(Interaction.InputBox("Введите следующее число", "Следующее число"));
                    resultOne = resultOne + numberThree;
                    string txtTwo = "Сумма нового числа равна: " + resultOne;
                    MessageBox.Show(txtTwo);
                }
                while (numberThree > 0);
                string txtfinal = "Сумма ИТОГОВОГО числа равна: " + resultOne;
                MessageBox.Show(txtfinal);
            }
            catch
            {
                MessageBox.Show("Вы ввели не числа!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
