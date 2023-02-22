using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Var2
{
    /*Написати програму розрахунку вартості замовлення піци. Вхідні
    дані для розрахунку – сорт піци (до 4-х найменувань) і кількість
    піц. Вибір сорту реалізувати через RadioButton. Якщо кількість
    замовлень більше 20, то надається знижка 10%.*/

    internal static class Program
    {
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
