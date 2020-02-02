namespace Presentationslager
{
    partial class Meny
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
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 415);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 0;
            this.TillbakaBtn.Text = "Gå tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.TillbakaBtn);
            this.Name = "Meny";
            this.Text = "Meny";
            this.Load += new System.EventHandler(this.Meny_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TillbakaBtn;
    }
}