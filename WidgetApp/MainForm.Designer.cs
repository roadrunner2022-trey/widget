
namespace WidgetApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWidgetName = new System.Windows.Forms.TextBox();
            this.groupBoxWidgetType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.listBoxSubType = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblWarningName = new System.Windows.Forms.Label();
            this.lblWarningType = new System.Windows.Forms.Label();
            this.lblWarningSubType = new System.Windows.Forms.Label();
            this.btnShowWidgets = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblWidgetName = new System.Windows.Forms.Label();
            this.lblSubTypes = new System.Windows.Forms.Label();
            this.groupBoxWidgetType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();

            // 
            // textBoxWidgetName
            // 
            this.textBoxWidgetName.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxWidgetName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxWidgetName.Location = new System.Drawing.Point(174, 24);
            this.textBoxWidgetName.Name = "textBoxWidgetName";
            this.textBoxWidgetName.Size = new System.Drawing.Size(180, 20);
            this.textBoxWidgetName.TabIndex = 2;
            this.textBoxWidgetName.TextChanged += new System.EventHandler(this.textBoxWidgetName_TextChanged);

            // 
            // groupBoxWidgetType
            // 
            this.groupBoxWidgetType.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWidgetType.Controls.Add(this.radioButton2);
            this.groupBoxWidgetType.Controls.Add(this.radioButton1);
            this.groupBoxWidgetType.Controls.Add(this.radioButtonB);
            this.groupBoxWidgetType.Controls.Add(this.radioButtonA);
            this.groupBoxWidgetType.Location = new System.Drawing.Point(174, 66);
            this.groupBoxWidgetType.Name = "groupBoxWidgetType";
            this.groupBoxWidgetType.Size = new System.Drawing.Size(180, 51);
            this.groupBoxWidgetType.TabIndex = 6;
            this.groupBoxWidgetType.TabStop = false;
            this.groupBoxWidgetType.Text = "Widget Type";
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(6, 19);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 5;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.checkButtonSelection);

            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(44, 19);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 6;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.checkButtonSelection);

            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.checkButtonSelection);

            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(119, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.checkButtonSelection);

            // 
            // listBoxSubType
            // 
            this.listBoxSubType.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBoxSubType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxSubType.FormattingEnabled = true;
            this.listBoxSubType.Location = new System.Drawing.Point(174, 148);
            this.listBoxSubType.Name = "listBoxSubType";
            this.listBoxSubType.Size = new System.Drawing.Size(180, 69);
            this.listBoxSubType.TabIndex = 7;
            this.listBoxSubType.SelectedIndexChanged += new System.EventHandler(this.subtypeChanged);

            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreate.Location = new System.Drawing.Point(174, 239);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Widget";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // 
            // lblWarningName
            // 
            this.lblWarningName.AutoSize = true;
            this.lblWarningName.BackColor = System.Drawing.Color.Transparent;
            this.lblWarningName.ForeColor = System.Drawing.Color.Red;
            this.lblWarningName.Location = new System.Drawing.Point(360, 27);
            this.lblWarningName.Name = "lblWarningName";
            this.lblWarningName.Size = new System.Drawing.Size(0, 13);
            this.lblWarningName.TabIndex = 10;
            this.lblWarningName.Visible = false;

            // 
            // lblWarningType
            // 
            this.lblWarningType.AutoSize = true;
            this.lblWarningType.BackColor = System.Drawing.Color.Transparent;
            this.lblWarningType.ForeColor = System.Drawing.Color.Red;
            this.lblWarningType.Location = new System.Drawing.Point(360, 85);
            this.lblWarningType.Name = "lblWarningType";
            this.lblWarningType.Size = new System.Drawing.Size(0, 13);
            this.lblWarningType.TabIndex = 11;
            this.lblWarningType.Visible = false;

            // 
            // lblWarningSubType
            // 
            this.lblWarningSubType.AutoSize = true;
            this.lblWarningSubType.BackColor = System.Drawing.Color.Transparent;
            this.lblWarningSubType.ForeColor = System.Drawing.Color.Red;
            this.lblWarningSubType.Location = new System.Drawing.Point(360, 180);
            this.lblWarningSubType.Name = "lblWarningSubType";
            this.lblWarningSubType.Size = new System.Drawing.Size(0, 13);
            this.lblWarningSubType.TabIndex = 12;
            this.lblWarningSubType.Visible = false;

            // 
            // btnShowWidgets
            // 
            this.btnShowWidgets.Location = new System.Drawing.Point(174, 330);
            this.btnShowWidgets.Name = "btnShowWidgets";
            this.btnShowWidgets.Size = new System.Drawing.Size(166, 23);
            this.btnShowWidgets.TabIndex = 14;
            this.btnShowWidgets.Text = "Show Widgets in Database";
            this.btnShowWidgets.UseVisualStyleBackColor = true;
            this.btnShowWidgets.Click += new System.EventHandler(this.GetAllWidgets);

            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(174, 330);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(180, 23);
            this.btnHide.TabIndex = 15;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Visible = false;
            this.btnHide.Click += new System.EventHandler(this.HideData);

            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.sub_type,
            this.date,
            this.time});
            this.grid.GridColor = System.Drawing.SystemColors.Desktop;
            this.grid.Location = new System.Drawing.Point(0, 366);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(547, 194);
            this.grid.TabIndex = 16;
            this.grid.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            // 
            // sub_type
            // 
            this.sub_type.HeaderText = "Sub-Type";
            this.sub_type.Name = "sub_type";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // LblWidgetName
            // 
            this.LblWidgetName.AutoSize = true;
            this.LblWidgetName.BackColor = System.Drawing.Color.Transparent;
            this.LblWidgetName.Location = new System.Drawing.Point(171, 8);
            this.LblWidgetName.Name = "LblWidgetName";
            this.LblWidgetName.Size = new System.Drawing.Size(72, 13);
            this.LblWidgetName.TabIndex = 3;
            this.LblWidgetName.Text = "Widget Name";
            // 
            // lblSubTypes
            // 
            this.lblSubTypes.AutoSize = true;
            this.lblSubTypes.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTypes.Location = new System.Drawing.Point(171, 132);
            this.lblSubTypes.Name = "lblSubTypes";
            this.lblSubTypes.Size = new System.Drawing.Size(183, 13);
            this.lblSubTypes.TabIndex = 8;
            this.lblSubTypes.Text = "Widget Sub-Type (Please select one)";

            // 
            // MainForm components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WidgetApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 560);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShowWidgets);
            this.Controls.Add(this.lblWarningSubType);
            this.Controls.Add(this.lblWarningType);
            this.Controls.Add(this.lblWarningName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSubTypes);
            this.Controls.Add(this.listBoxSubType);
            this.Controls.Add(this.groupBoxWidgetType);
            this.Controls.Add(this.LblWidgetName);
            this.Controls.Add(this.textBoxWidgetName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Widget Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxWidgetType.ResumeLayout(false);
            this.groupBoxWidgetType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /* Imports needed for form */
        #endregion
        private System.Windows.Forms.TextBox textBoxWidgetName;
        private System.Windows.Forms.GroupBox groupBoxWidgetType;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.ListBox listBoxSubType;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblWarningName;
        private System.Windows.Forms.Label lblWarningType;
        private System.Windows.Forms.Label lblWarningSubType;
        private System.Windows.Forms.Button btnShowWidgets;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Label LblWidgetName;
        private System.Windows.Forms.Label lblSubTypes;
    }
}

