﻿namespace Presentationslager
{
    partial class Login
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
            this.LösenordTextBox = new System.Windows.Forms.TextBox();
            this.AnvIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoggaInBtn = new System.Windows.Forms.Button();
            this.felLösenLabel = new System.Windows.Forms.Label();
            this.expediterComboBox = new System.Windows.Forms.ComboBox();
            this.AvslutaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LösenordTextBox
            // 
            this.LösenordTextBox.Location = new System.Drawing.Point(120, 106);
            this.LösenordTextBox.Name = "LösenordTextBox";
            this.LösenordTextBox.PasswordChar = '*';
            this.LösenordTextBox.Size = new System.Drawing.Size(100, 20);
            this.LösenordTextBox.TabIndex = 0;
            this.LösenordTextBox.Text = "klas123";
            // 
            // AnvIDTextBox
            // 
            this.AnvIDTextBox.Location = new System.Drawing.Point(120, 66);
            this.AnvIDTextBox.Name = "AnvIDTextBox";
            this.AnvIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnvIDTextBox.TabIndex = 1;
            this.AnvIDTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AnställningsNummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lösenord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Välj en expedit";
            // 
            // LoggaInBtn
            // 
            this.LoggaInBtn.Location = new System.Drawing.Point(120, 130);
            this.LoggaInBtn.Name = "LoggaInBtn";
            this.LoggaInBtn.Size = new System.Drawing.Size(75, 23);
            this.LoggaInBtn.TabIndex = 5;
            this.LoggaInBtn.Text = "Logga In";
            this.LoggaInBtn.UseVisualStyleBackColor = true;
            this.LoggaInBtn.Click += new System.EventHandler(this.LoggaInBtn_Click);
            // 
            // felLösenLabel
            // 
            this.felLösenLabel.AutoSize = true;
            this.felLösenLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.felLösenLabel.Location = new System.Drawing.Point(15, 140);
            this.felLösenLabel.Name = "felLösenLabel";
            this.felLösenLabel.Size = new System.Drawing.Size(0, 13);
            this.felLösenLabel.TabIndex = 6;
            // 
            // expediterComboBox
            // 
            this.expediterComboBox.FormattingEnabled = true;
            this.expediterComboBox.Location = new System.Drawing.Point(120, 9);
            this.expediterComboBox.Name = "expediterComboBox";
            this.expediterComboBox.Size = new System.Drawing.Size(121, 21);
            this.expediterComboBox.TabIndex = 7;
            this.expediterComboBox.SelectedIndexChanged += new System.EventHandler(this.expediterComboBox_SelectedIndexChanged);
            // 
            // AvslutaBtn
            // 
            this.AvslutaBtn.Location = new System.Drawing.Point(205, 180);
            this.AvslutaBtn.Name = "AvslutaBtn";
            this.AvslutaBtn.Size = new System.Drawing.Size(75, 23);
            this.AvslutaBtn.TabIndex = 8;
            this.AvslutaBtn.Text = "Avsluta";
            this.AvslutaBtn.UseVisualStyleBackColor = true;
            this.AvslutaBtn.Click += new System.EventHandler(this.AvslutaBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 215);
            this.ControlBox = false;
            this.Controls.Add(this.AvslutaBtn);
            this.Controls.Add(this.expediterComboBox);
            this.Controls.Add(this.felLösenLabel);
            this.Controls.Add(this.LoggaInBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnvIDTextBox);
            this.Controls.Add(this.LösenordTextBox);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LösenordTextBox;
        private System.Windows.Forms.TextBox AnvIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoggaInBtn;
        private System.Windows.Forms.Label felLösenLabel;
        private System.Windows.Forms.ComboBox expediterComboBox;
        private System.Windows.Forms.Button AvslutaBtn;
    }
}

