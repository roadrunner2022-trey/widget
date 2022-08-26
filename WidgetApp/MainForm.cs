using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WidgetApp
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        /* Declare variables */
        private LocalDB db; //local database connection
        private string widgetName = "";
        private string primaryType = ""; //variable to determine which radio button was selected to query the correct records
        private string subType = "";

        /* Entry point called by Program.cs Used to initialize the form */
        public MainForm()
        {
            //Call the MainForm.Designer partial class to initialize the form and layout
            InitializeComponent();
        }


        //Called by the form designer class which initializes all the gui objects
        private void MainForm_Load(object sender, EventArgs e)
        {
            //create database instance
            db = new LocalDB();
        }


        /* used to dynamically obtain subtypes by querying database for data*/
        private void getSubtypes()
        {
            //clear out old subtypes first
            listBoxSubType.Items.Clear();

            /* select the secondary types from types table where the primary types equal the "selected" variable*/
            string query = "SELECT secondary_type FROM types WHERE primary_type='" + primaryType + "';";
            List<string> queryResults = db.Select(query, 1);

            //Loop through all rows of data returned from query
            foreach(string type in queryResults)
            {
                listBoxSubType.Items.Add(type);
            }
        }


        /* Used whenever radio button is selected. Check which button was selected and update selected variable for the query*/
        private void checkButtonSelection(object sender, EventArgs e)
        {
            lblWarningType.Visible = false; //remove validation warning if there is one
            RadioButton selectedType = (RadioButton)sender;
            primaryType = (selectedType.Text);
            getSubtypes();
        }

        /* event function for when any selection for subtype changes*/
        private void subtypeChanged(object sender, EventArgs e)
        {
            this.lblWarningSubType.Visible = false; //remove validation warning if there is one
            this.subType = (string)listBoxSubType.SelectedItem;
        }

        /* Once the user creates widget, this prepares the data and creates an insert string to pass to db for updating*/
        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnHide.Visible = false;
            btnShowWidgets.Visible = true;

            if (!FieldsValidated())
            {
                MessageBox.Show("Please correct errors on form");
                return;
            }

            /* Format the values that will be inserted */
            this.widgetName = FormatStringForQueryValues((string)textBoxWidgetName.Text);
            string date = FormatStringForQueryValues(DateTime.Today.ToString("MM/dd/yyyy"));
            string time = FormatStringForQueryValues(DateTime.Now.ToString("hh:mm:ss"));
            this.primaryType = FormatStringForQueryValues(this.primaryType);
            this.subType = FormatStringForQueryValues(this.subType);

            Console.WriteLine("Data to be written to db:");
            Console.WriteLine("Name: " + this.widgetName);
            Console.WriteLine("Type: " + this.primaryType);
            Console.WriteLine("Sub-Type: " + this.subType);
            Console.WriteLine("Date: " + date);
            Console.WriteLine("Time: " + time);

            /*Insert query with substitution parameters*/
            string query = "INSERT INTO widgets (name, type, subtype, date, time) VALUES (@name, @type, @subtype, @date, @time)";

            /* call db object 'insert' function */
            int rowsInserted = db.Insert(query, this.widgetName, this.primaryType, this.subType, date, time);
            
            if(rowsInserted > 0)
            {
                MessageBox.Show("Data inserted successfully!");
                ClearFields();
            }

            btnShowWidgets.Visible = true;
            btnHide.Visible = false;
            grid.Rows.Clear();
            grid.Visible = false;
        }

        private string FormatStringForQueryValues(string s)
        {
            return "\"" + s + "\"";
        }

        private bool FieldsValidated()
        {
            bool valid = true;  

            if(this.textBoxWidgetName.Text == "")
            {
                lblWarningName.Text = "Name field is required";
                lblWarningName.Visible = true;
                valid = false;
            }

            if ( !(this.radioButton1.Checked || this.radioButton2.Checked || this.radioButtonA.Checked || this.radioButtonB.Checked) )
            {
                lblWarningType.Text = "Widget Type is required";
                lblWarningType.Visible = true;
                valid = false;
            }

            if( this.listBoxSubType.SelectedItem == null)
            {
                lblWarningSubType.Text = "Widget Sub-Type is required";
                lblWarningSubType.Visible = true;
                valid = false;
            }

            return valid;
        }

        private void textBoxWidgetName_TextChanged(object sender, EventArgs e)
        {
            this.lblWarningName.Visible = false; //remove validation warning once user starts to change the field
        }

        //clear fields after successful creation
        private void ClearFields()
        {
            textBoxWidgetName.Text = "";
            radioButton2.Checked = false;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            listBoxSubType.Items.Clear();
        }

        private void GetAllWidgets(object sender, EventArgs e)
        {
            this.btnHide.Visible = true;
            this.btnShowWidgets.Visible = false;
            List<string> items = db.Select("Select name, type, subtype, date, time FROM widgets", 5);
            foreach(string s in items)
            {
                string[] strings = s.Split(',');
                DataGridViewRow row = (DataGridViewRow) grid.Rows[0].Clone();
                row.Cells[0].Value = strings[0];
                row.Cells[1].Value = strings[1];
                row.Cells[2].Value = strings[2];
                row.Cells[3].Value = strings[3];
                row.Cells[4].Value = strings[4];

                grid.Rows.Add(row);

                Console.WriteLine(strings[0]);
                //listBoxDatabase.Items.Add(s + "\t");
            }
            grid.Visible = true;
        }

        private void HideData(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            grid.Visible = false;

            this.btnShowWidgets.Visible = true;
            this.btnHide.Visible = false;
        }

    }
}
