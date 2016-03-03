using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MVP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMVP());

            FormMVP view = new FormMVP();
            Presenter presenter = new Presenter(view);
            //Presenter presenter = new Presenter(view = new FormMVP());
            Application.Run(view);
        }
    }
}
