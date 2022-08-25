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
    public partial class MainForm : System.Windows.Forms.Form
    {
        
        LocalDB db;
        public MainForm()
        {
            db = new LocalDB(); 
            //Call the MainForm.Designer part of class to initialize the form and layout
            InitializeComponent();


            /* Only modify form components once intialized*/
            this.QueryResults.Text = "";
           
        }

        private void getData(object sender, EventArgs e)
        {
            string query = "SELECT * FROM widgets";
            string data = "";
            SqlDataReader dr = db.Select(query);

            //Loop through all rows of data selected
            while (dr.Read())
            {
                data += dr.GetValue(0) + " - " + dr.GetValue(1) + "\n";
            }

            this.QueryResults.Text = data;
            dr.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
