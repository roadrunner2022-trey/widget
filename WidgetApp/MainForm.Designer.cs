
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
            this.QueryResults = new System.Windows.Forms.Label();
            this.queryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueryResults
            // 
            this.QueryResults.AutoSize = true;
            this.QueryResults.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QueryResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QueryResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QueryResults.Location = new System.Drawing.Point(251, 116);
            this.QueryResults.MinimumSize = new System.Drawing.Size(300, 100);
            this.QueryResults.Name = "QueryResults";
            this.QueryResults.Size = new System.Drawing.Size(300, 100);
            this.QueryResults.TabIndex = 0;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(325, 74);
            this.queryButton.Name = "queryButton";
            this.queryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.queryButton.Size = new System.Drawing.Size(154, 23);
            this.queryButton.TabIndex = 1;
            this.queryButton.Text = "Query Database";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.getData);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.QueryResults);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QueryResults;
        private System.Windows.Forms.Button queryButton;
    }
}

