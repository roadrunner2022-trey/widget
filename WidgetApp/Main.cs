using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WidgetApp
{
    public partial class Main : Form
    {
        
        int count = 0;

        public Main()
        {

            InitializeComponent();

            countLabel.Text = "0";
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|widgetDB.mdf;Integrated Security=True");
            SqlDataReader dr;
            SqlCommand command;
            string query = "SELECT * FROM widgets";
            string data = "";
            connection.Open();

            command = new SqlCommand(query, connection);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                data += dr.GetValue(0) + " - " + dr.GetValue(1) + "\n";
            }

            Console.WriteLine("Data from db:\n" + data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countLabel.Text = Convert.ToString(++count);
        }
    }
}
