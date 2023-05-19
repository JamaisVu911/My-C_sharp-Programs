using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Independent_work_6
{
    class Independent_work_6
    {
        static void Main(string[] args)
        {
            string week;
            int number;

            week = Interaction.InputBox("Введите день недели", "Ввод дня недели");

            switch ( week)
            {
                case "Понедельник":
                    number = 1;
                    MessageBox.Show("Введенный день недели " + number);
                    break;
                
                case "Вторник":
                    number = 2;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                case "Среда":
                    number = 3;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                case "Четверг":
                    number = 4;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                case "Пятница":
                    number = 5;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                case "Суббота":
                    number = 6;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                case "Воскресенье":
                    number = 7;
                    MessageBox.Show("Введенный день недели " + number);
                    break;

                default:
                    MessageBox.Show("Такого дня нет");
                    break;
            }

        }
    }
}
