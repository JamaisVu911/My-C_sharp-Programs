using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Independent_work_1
{
    class Independent_work_1
    {
        static void Main(string[] args)
        {
            int number;

            MessageBox.Show("Выполняется программа", "Начало");

            try
            {
                number = Int32.Parse(Interaction.InputBox("Введите число которое делится на 3 и 7:", "Число"));

                if (number % 3 == 0)
                {
                    if (number % 7 == 0)
                    {
                        MessageBox.Show("Да, число делится на 3 и 7!", "Число");
                    }
                }

                else
                {
                    MessageBox.Show("Нет, число НЕделится на 3 и 7!", "Число");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не число!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
