/*
 *Author: Trey Jones 
 *Date: 08/26/2022
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WidgetApp
{
    public partial class MainForm : System.Windows.Forms.Form
    {

        /* Declare variables */
        private Database db; //database connection variable

        /* Variables for the widget creation (except date and time which is generated automatically upon creation) */
        private string widgetName = "";
        private string primaryType = ""; //variable to determine which radio button was selected to query the correct records
        private string subType = ""; //subtype variable for widget

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
            db = new Database();
        }


        /* Used whenever radio button is selected. Check which button was selected and update selected variable for the query*/
        private void checkButtonSelection(object sender, EventArgs e)
        {
            lblWarningType.Visible = false; //remove validation warning since a button has now been selected
            RadioButton selectedType = (RadioButton) sender;
            primaryType = (selectedType.Text);
            getSubtypes();
        }

        /* used to dynamically obtain subtypes by querying database for data*/
        private void getSubtypes()
        {
            //clear out old subtypes first
            listBoxSubType.Items.Clear();

            /* select the secondary types from types table where the primary types equal the "primaryType" variable*/
            string query = "SELECT secondary_type FROM types WHERE primary_type='" + primaryType + "';";
            List<string> queryResults = db.Select(query, 1); /* NOTE: second arg is for number of fields needed to obtain per row*/

            //Loop through all rows of data returned from query and add subType to list box
            foreach (string type in queryResults)
            {
                listBoxSubType.Items.Add(type);
            }
        }


        /* event function for when any selection for subtype changes*/
        private void subtypeChanged(object sender, EventArgs e)
        {
            this.lblWarningSubType.Visible = false; //remove validation warning since subType selected
            this.subType = (string) listBoxSubType.SelectedItem;
        }

        /* Once the user creates widget, this prepares the data and creates an insert string to pass to db for updating*/
        private void btnCreate_Click(object sender, EventArgs e)
        {
            /* Confirm that all fields are valid */
            if (!FieldsValidated())
            {
                MessageBox.Show("Please correct errors on form");
                return;
            }

            /* Format the values that will be inserted with quotes for inserting strings into database */
            this.widgetName = FormatStringForQueryValues((string)textBoxWidgetName.Text);
            string date = FormatStringForQueryValues(DateTime.Today.ToString("MM/dd/yyyy"));
            string time = FormatStringForQueryValues(DateTime.Now.ToString("hh:mm:ss"));
            this.primaryType = FormatStringForQueryValues(this.primaryType);
            this.subType = FormatStringForQueryValues(this.subType);

            /*Insert query with substitution parameters*/
            string query = "INSERT INTO widgets (name, type, subtype, date, time) VALUES (@name, @type, @subtype, @date, @time)";

            /* call db object 'insert' function */
            int rowsInserted = db.Insert(query, this.widgetName, this.primaryType, this.subType, date, time);
            
            if(rowsInserted > 0)
            {
                MessageBox.Show("Data inserted successfully!");
                ClearFields();
            }

            //reset data query after submission
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

            //check to ensure widget has a name
            if(this.textBoxWidgetName.Text == "")
            {
                lblWarningName.Text = "Name field is required";
                lblWarningName.Visible = true;
                valid = false;
            }

            //check to ensure primary type is selected
            if ( !(this.radioButton1.Checked || this.radioButton2.Checked || this.radioButtonA.Checked || this.radioButtonB.Checked) )
            {
                lblWarningType.Text = "Widget Type is required";
                lblWarningType.Visible = true;
                valid = false;
            }

            //check to ensure subtype is selected
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

        /* used as a user tool to see all widgets in database */
        private void GetAllWidgets(object sender, EventArgs e)
        {
            this.btnHide.Visible = true;
            this.btnShowWidgets.Visible = false;
            List<string> items = db.Select("Select name, type, subtype, date, time FROM widgets", 5);
            foreach(string s in items)
            {
                /* split each column in row returned */
                string[] strings = s.Split(',');

                //add each value to grid row
                DataGridViewRow row = (DataGridViewRow) grid.Rows[0].Clone();
                row.Cells[0].Value = strings[0];
                row.Cells[1].Value = strings[1];
                row.Cells[2].Value = strings[2];
                row.Cells[3].Value = strings[3];
                row.Cells[4].Value = strings[4];

                //add row to grid
                grid.Rows.Add(row);
            }
            grid.Visible = true;
        }

        /* clears and hides the grid upon request */
        private void HideData(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            grid.Visible = false;

            this.btnShowWidgets.Visible = true;
            this.btnHide.Visible = false;
        }

    }
}
