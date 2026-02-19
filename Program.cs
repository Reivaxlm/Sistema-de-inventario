using System;
using System.Windows.Forms;

namespace Tienda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Estas líneas son vitales para Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí es donde lanzamos tu ventana principal
            Application.Run(new MainForm());
        }
    }
}