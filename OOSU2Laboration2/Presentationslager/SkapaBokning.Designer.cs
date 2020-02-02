namespace Presentationslager
{
    partial class SkapaBokning
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
            this.inloggadAnvändareLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rollLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.återlämningsDatumLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.medlemsIDlabel = new System.Windows.Forms.Label();
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
            this.tillgängligaBöckerListBox.Location = new System.Drawing.Point(25, 148);
            this.tillgängligaBöckerListBox.Name = "tillgängligaBöckerListBox";
            this.tillgängligaBöckerListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tillgängligaBöckerListBox.Size = new System.Drawing.Size(407, 108);
            this.tillgängligaBöckerListBox.TabIndex = 1;
            this.tillgängligaBöckerListBox.SelectedIndexChanged += new System.EventHandler(this.tillgängligaBöckerListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vänligen välj böcker att boka:";
            // 
            // startDatumPicker
            // 
            this.startDatumPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatumPicker.Location = new System.Drawing.Point(25, 94);
            this.startDatumPicker.Name = "startDatumPicker";
            this.startDatumPicker.Size = new System.Drawing.Size(200, 20);
            this.startDatumPicker.TabIndex = 3;
            this.startDatumPicker.ValueChanged += new System.EventHandler(this.startDatumPicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
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
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inloggad som";
            // 
            // bokaBtn
            // 
            this.bokaBtn.Location = new System.Drawing.Point(354, 361);
            this.bokaBtn.Name = "bokaBtn";
            this.bokaBtn.Size = new System.Drawing.Size(75, 23);
            this.bokaBtn.TabIndex = 6;
            this.bokaBtn.Text = "Boka";
            this.bokaBtn.UseVisualStyleBackColor = true;
            this.bokaBtn.Click += new System.EventHandler(this.bokaBtn_Click);
            // 
            // medlemComboBox
            // 
            this.medlemComboBox.FormattingEnabled = true;
            this.medlemComboBox.Location = new System.Drawing.Point(25, 280);
            this.medlemComboBox.Name = "medlemComboBox";
            this.medlemComboBox.Size = new System.Drawing.Size(200, 21);
            this.medlemComboBox.TabIndex = 7;
            this.medlemComboBox.SelectedIndexChanged += new System.EventHandler(this.medlemComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Välj medlem för bokningen";
            // 
            // inloggadAnvändareLabel
            // 
            this.inloggadAnvändareLabel.AutoSize = true;
            this.inloggadAnvändareLabel.Location = new System.Drawing.Point(87, 13);
            this.inloggadAnvändareLabel.Name = "inloggadAnvändareLabel";
            this.inloggadAnvändareLabel.Size = new System.Drawing.Size(22, 13);
            this.inloggadAnvändareLabel.TabIndex = 9;
            this.inloggadAnvändareLabel.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Roll:";
            // 
            // rollLabel
            // 
            this.rollLabel.AutoSize = true;
            this.rollLabel.Location = new System.Drawing.Point(46, 30);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(19, 13);
            this.rollLabel.TabIndex = 11;
            this.rollLabel.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Låningstiden är 14 dagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Beräknat återlämningsdatum:";
            // 
            // återlämningsDatumLabel
            // 
            this.återlämningsDatumLabel.AutoSize = true;
            this.återlämningsDatumLabel.Location = new System.Drawing.Point(256, 100);
            this.återlämningsDatumLabel.Name = "återlämningsDatumLabel";
            this.återlämningsDatumLabel.Size = new System.Drawing.Size(52, 13);
            this.återlämningsDatumLabel.TabIndex = 14;
            this.återlämningsDatumLabel.Text = "---------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Medlemmens ID:";
            // 
            // medlemsIDlabel
            // 
            this.medlemsIDlabel.AutoSize = true;
            this.medlemsIDlabel.Location = new System.Drawing.Point(111, 308);
            this.medlemsIDlabel.Name = "medlemsIDlabel";
            this.medlemsIDlabel.Size = new System.Drawing.Size(19, 13);
            this.medlemsIDlabel.TabIndex = 16;
            this.medlemsIDlabel.Text = "----";
            // 
            // Bokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 396);
            this.ControlBox = false;
            this.Controls.Add(this.medlemsIDlabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.återlämningsDatumLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rollLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inloggadAnvändareLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medlemComboBox);
            this.Controls.Add(this.bokaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDatumPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tillgängligaBöckerListBox);
            this.Controls.Add(this.tillbakaBtn);
            this.Name = "Bokning";
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
        private System.Windows.Forms.Label inloggadAnvändareLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rollLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label återlämningsDatumLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label medlemsIDlabel;
    }
}