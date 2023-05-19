using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Independent_work_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string week;
            string number;

            week = Interaction.InputBox("Введите день недели", "Ввод дня недели");

            if (week == "Понедельник")
            {
                number = "Первый";
                MessageBox.Show("Введенный день недели " + number);
            }
            else if (week == "Вторник")
            {
                number = "Второй";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else if (week == "Среда")
            {
                number = "Третий";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else if (week == "Четверг")
            {
                number = "Четвертый";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else if (week == "Пятница")
            {
                number = "Пятый";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else if (week == "Суббота")
            {
                number = "Шестой";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else if (week == "Воскресенье")
            {
                number = "Седьмой";
                MessageBox.Show("Введенный день недели " + number);
            }
            
            else MessageBox.Show("Такого дня нет");
        }
    }
}
