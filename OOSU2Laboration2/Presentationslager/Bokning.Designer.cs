namespace Presentationslager
{
    partial class Bokning
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
            this.tillbakaBtn = new System.Windows.Forms.Button();
            this.tillgängligaBöckerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bokaBtn = new System.Windows.Forms.Button();
            this.medlemComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tillbakaBtn
            // 
            this.tillbakaBtn.Location = new System.Drawing.Point(22, 361);
            this.tillbakaBtn.Name = "tillbakaBtn";
            this.tillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.tillbakaBtn.TabIndex = 0;
            this.tillbakaBtn.Text = "Gå tillbaka";
            this.tillbakaBtn.UseVisualStyleBackColor = true;
            this.tillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // tillgängligaBöckerListBox
            // 
            this.tillgängligaBöckerListBox.FormattingEnabled = true;
            this.tillgängligaBöckerListBox.Location = new System.Drawing.Point(22, 63);
            this.tillgängligaBöckerListBox.Name = "tillgängligaBöckerListBox";
            this.tillgängligaBöckerListBox.Size = new System.Drawing.Size(183, 95);
            this.tillgängligaBöckerListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vänligen välj böcker att boka:";
            // 
            // startDatumPicker
            // 
            this.startDatumPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatumPicker.Location = new System.Drawing.Point(229, 63);
            this.startDatumPicker.Name = "startDatumPicker";
            this.startDatumPicker.Size = new System.Drawing.Size(200, 20);
            this.startDatumPicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Välj startdatum för bokningen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Välkommen till BOKningssystemet \"expeditNamn\"!";
            // 
            // bokaBtn
            // 
            this.bokaBtn.Location = new System.Drawing.Point(354, 361);
            this.bokaBtn.Name = "bokaBtn";
            this.bokaBtn.Size = new System.Drawing.Size(75, 23);
            this.bokaBtn.TabIndex = 6;
            this.bokaBtn.Text = "Boka";
            this.bokaBtn.UseVisualStyleBackColor = true;
            // 
            // medlemComboBox
            // 
            this.medlemComboBox.FormattingEnabled = true;
            this.medlemComboBox.Location = new System.Drawing.Point(229, 118);
            this.medlemComboBox.Name = "medlemComboBox";
            this.medlemComboBox.Size = new System.Drawing.Size(200, 21);
            this.medlemComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Välj medlem för bokningen";
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 396);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medlemComboBox);
            this.Controls.Add(this.bokaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDatumPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tillgängligaBöckerListBox);
            this.Controls.Add(this.tillbakaBtn);
            this.Name = "Meny";
            this.Text = "Meny";
            this.Load += new System.EventHandler(this.Meny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tillbakaBtn;
        private System.Windows.Forms.ListBox tillgängligaBöckerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startDatumPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bokaBtn;
        private System.Windows.Forms.ComboBox medlemComboBox;
        private System.Windows.Forms.Label label4;
    }
}