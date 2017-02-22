using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileHandler FH = new FileHandler();
            HandleProduct HP = new HandleProduct(FH);
            ShoppingCart SC = new ShoppingCart(HP);
            Application.Run(new View(FH, HP, SC));
        }
    }
}
