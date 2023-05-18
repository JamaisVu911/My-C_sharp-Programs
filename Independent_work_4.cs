using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Independent_work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string week;

            try
            {
                number = Int32.Parse(Interaction.InputBox("Введите число от 1 до 7", "Число"));

                switch(number)
                {

                    case 1:
                        week = "Понедельник";
                        break;
                    case 2:
                        week = "Вторник";
                        break;
                    case 3:
                        week = "Среда";
                        break;
                    case 4:
                        week = "Четверг";
                        break;
                    case 5:
                        week = "Пятница";
                        break;
                    case 6:
                        week = "Суббота";
                        break;
                    case 7:
                        week = "Воскресенье";
                        break;
                    default:
                        week = "Некорректное число";
                        break;
                }
                MessageBox.Show(week, "День недели");
            }
            catch
            {
                MessageBox.Show("Вы ввели не числа!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
