namespace Presentationslager
{
    partial class ÅterlämningAvBöcker
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
            this.allaBöckerPåBoknListBox = new System.Windows.Forms.ListBox();
            this.allaBokningarcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.återlämningBtn = new System.Windows.Forms.Button();
            this.tillbakaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allaBöckerPåBoknListBox
            // 
            this.allaBöckerPåBoknListBox.FormattingEnabled = true;
            this.allaBöckerPåBoknListBox.Location = new System.Drawing.Point(12, 78);
            this.allaBöckerPåBoknListBox.Name = "allaBöckerPåBoknListBox";
            this.allaBöckerPåBoknListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allaBöckerPåBoknListBox.Size = new System.Drawing.Size(251, 95);
            this.allaBöckerPåBoknListBox.TabIndex = 1;
            // 
            // allaBokningarcomboBox
            // 
            this.allaBokningarcomboBox.FormattingEnabled = true;
            this.allaBokningarcomboBox.Location = new System.Drawing.Point(12, 41);
            this.allaBokningarcomboBox.Name = "allaBokningarcomboBox";
            this.allaBokningarcomboBox.Size = new System.Drawing.Size(102, 21);
            this.allaBokningarcomboBox.TabIndex = 2;
            this.allaBokningarcomboBox.SelectedIndexChanged += new System.EventHandler(this.allaBokningarcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välj bokningsnummer:";
            // 
            // återlämningBtn
            // 
            this.återlämningBtn.Location = new System.Drawing.Point(12, 217);
            this.återlämningBtn.Name = "återlämningBtn";
            this.återlämningBtn.Size = new System.Drawing.Size(251, 34);
            this.återlämningBtn.TabIndex = 4;
            this.återlämningBtn.Text = "Återlämna markerade böcker";
            this.återlämningBtn.UseVisualStyleBackColor = true;
            this.återlämningBtn.Click += new System.EventHandler(this.återlämningBtn_Click);
            // 
            // tillbakaBtn
            // 
            this.tillbakaBtn.Location = new System.Drawing.Point(12, 270);
            this.tillbakaBtn.Name = "tillbakaBtn";
            this.tillbakaBtn.Size = new System.Drawing.Size(102, 23);
            this.tillbakaBtn.TabIndex = 5;
            this.tillbakaBtn.Text = "Tillbaka till meny";
            this.tillbakaBtn.UseVisualStyleBackColor = true;
            this.tillbakaBtn.Click += new System.EventHandler(this.tillbakaBtn_Click);
            // 
            // ÅterlämningAvBöcker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 305);
            this.ControlBox = false;
            this.Controls.Add(this.tillbakaBtn);
            this.Controls.Add(this.återlämningBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allaBokningarcomboBox);
            this.Controls.Add(this.allaBöckerPåBoknListBox);
            this.Name = "ÅterlämningAvBöcker";
            this.Text = "ÅterlämningAvBöcker";
            this.Load += new System.EventHandler(this.ÅterlämningAvBöcker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox allaBöckerPåBoknListBox;
        private System.Windows.Forms.ComboBox allaBokningarcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button återlämningBtn;
        private System.Windows.Forms.Button tillbakaBtn;
    }
}