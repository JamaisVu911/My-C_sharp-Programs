using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Independent_work_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOne, numberTwo;

            try
            {
                numberOne = Int32.Parse(Interaction.InputBox("Введите первое число", "Первое число"));
                numberTwo = Int32.Parse(Interaction.InputBox("Введите второе число", "Второе число"));

                if (numberOne > numberTwo)
                {
                    MessageBox.Show("Первое число больше", "Результат");
                }
                if(numberOne < numberTwo)
                {
                    MessageBox.Show("Второе число больше", "Результат");
                }
                if (numberOne == numberTwo)
                {
                    MessageBox.Show("Числа равны", "Результат");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели не числа!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
