/*
 *Author: Trey Jones 
 *Date: 08/26/2022
 */
using System;
using System.Windows.Forms;

namespace WidgetApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        //Initial Entry point for program
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
