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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FakturorComboBox = new System.Windows.Forms.ComboBox();
            this.fakturaNummerlabel = new System.Windows.Forms.Label();
            this.fakturaTotalPrislabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fakturaÅterlämnadeböckerListBox = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allaBöckerPåBoknListBox
            // 
            this.allaBöckerPåBoknListBox.FormattingEnabled = true;
            this.allaBöckerPåBoknListBox.Location = new System.Drawing.Point(12, 52);
            this.allaBöckerPåBoknListBox.Name = "allaBöckerPåBoknListBox";
            this.allaBöckerPåBoknListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.allaBöckerPåBoknListBox.Size = new System.Drawing.Size(251, 134);
            this.allaBöckerPåBoknListBox.TabIndex = 1;
            // 
            // allaBokningarcomboBox
            // 
            this.allaBokningarcomboBox.FormattingEnabled = true;
            this.allaBokningarcomboBox.Location = new System.Drawing.Point(12, 25);
            this.allaBokningarcomboBox.Name = "allaBokningarcomboBox";
            this.allaBokningarcomboBox.Size = new System.Drawing.Size(102, 21);
            this.allaBokningarcomboBox.TabIndex = 2;
            this.allaBokningarcomboBox.SelectedIndexChanged += new System.EventHandler(this.allaBokningarcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genererad Faktura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fakturanummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TotalPris:";
            // 
            // FakturorComboBox
            // 
            this.FakturorComboBox.FormattingEnabled = true;
            this.FakturorComboBox.Location = new System.Drawing.Point(384, 9);
            this.FakturorComboBox.Name = "FakturorComboBox";
            this.FakturorComboBox.Size = new System.Drawing.Size(121, 21);
            this.FakturorComboBox.TabIndex = 9;
            this.FakturorComboBox.SelectedIndexChanged += new System.EventHandler(this.FakturorComboBox_SelectedIndexChanged);
            // 
            // fakturaNummerlabel
            // 
            this.fakturaNummerlabel.AutoSize = true;
            this.fakturaNummerlabel.Location = new System.Drawing.Point(358, 33);
            this.fakturaNummerlabel.Name = "fakturaNummerlabel";
            this.fakturaNummerlabel.Size = new System.Drawing.Size(16, 13);
            this.fakturaNummerlabel.TabIndex = 10;
            this.fakturaNummerlabel.Text = "---";
            // 
            // fakturaTotalPrislabel
            // 
            this.fakturaTotalPrislabel.AutoSize = true;
            this.fakturaTotalPrislabel.Location = new System.Drawing.Point(339, 52);
            this.fakturaTotalPrislabel.Name = "fakturaTotalPrislabel";
            this.fakturaTotalPrislabel.Size = new System.Drawing.Size(19, 13);
            this.fakturaTotalPrislabel.TabIndex = 11;
            this.fakturaTotalPrislabel.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Återlämnade böcker:";
            // 
            // fakturaÅterlämnadeböckerListBox
            // 
            this.fakturaÅterlämnadeböckerListBox.FormattingEnabled = true;
            this.fakturaÅterlämnadeböckerListBox.Location = new System.Drawing.Point(287, 86);
            this.fakturaÅterlämnadeböckerListBox.Name = "fakturaÅterlämnadeböckerListBox";
            this.fakturaÅterlämnadeböckerListBox.Size = new System.Drawing.Size(218, 95);
            this.fakturaÅterlämnadeböckerListBox.TabIndex = 13;
            this.fakturaÅterlämnadeböckerListBox.SelectedIndexChanged += new System.EventHandler(this.fakturaÅterlämnadeböckerListBox_SelectedIndexChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(137, 25);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ÅterlämningAvBöcker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 305);
            this.ControlBox = false;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.fakturaÅterlämnadeböckerListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fakturaTotalPrislabel);
            this.Controls.Add(this.fakturaNummerlabel);
            this.Controls.Add(this.FakturorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FakturorComboBox;
        private System.Windows.Forms.Label fakturaNummerlabel;
        private System.Windows.Forms.Label fakturaTotalPrislabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox fakturaÅterlämnadeböckerListBox;
        private System.Windows.Forms.Button refreshBtn;
    }
}