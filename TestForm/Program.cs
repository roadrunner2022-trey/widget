using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForm
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
            Application.Run(new Form1());

            /*data base connection variables*/
            string host = "";
            string dbName = "widgetDB";
            string user = "widgetMaster94";
            string password = "1W1dg3t43ver!!";

            string connectionString = "server=" + host + "; database=" + dbName + "; uid=" + user + "; pwd=" + password + ";";

            MySqlConnection cnn;




            Console.WriteLine("Hello World!");
        }
    }
}
