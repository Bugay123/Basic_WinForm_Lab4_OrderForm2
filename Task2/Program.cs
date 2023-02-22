using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    internal static class Program
    {
        /*Модифікувати форму реєстрації (з лаб. 2). Додати на форму
        вибір року, місяця (числа від 1 до 12), дня народження (від 1 до 31).
        Використати і налаштувати NumericUpDown. Додати на форму
        перемикач для вибору статі (чолові чи жінка). Усі введені дані
        вивести в текстове поле.*/

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
