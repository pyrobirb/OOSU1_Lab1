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
            this.BokningBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BorttagningBtn = new System.Windows.Forms.Button();
            this.UtlämningBtn = new System.Windows.Forms.Button();
            this.återlämningBtn = new System.Windows.Forms.Button();
            this.tillbakaBtn = new System.Windows.Forms.Button();
            this.inloggadAnvändareLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BokningBtn
            // 
            this.BokningBtn.Location = new System.Drawing.Point(50, 72);
            this.BokningBtn.Name = "BokningBtn";
            this.BokningBtn.Size = new System.Drawing.Size(200, 39);
            this.BokningBtn.TabIndex = 0;
            this.BokningBtn.Text = "Bokning av böcker";
            this.BokningBtn.UseVisualStyleBackColor = true;
            this.BokningBtn.Click += new System.EventHandler(this.BokningBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Välkommen ";
            // 
            // BorttagningBtn
            // 
            this.BorttagningBtn.Location = new System.Drawing.Point(50, 117);
            this.BorttagningBtn.Name = "BorttagningBtn";
            this.BorttagningBtn.Size = new System.Drawing.Size(200, 39);
            this.BorttagningBtn.TabIndex = 4;
            this.BorttagningBtn.Text = "Borttagning av Bokning";
            this.BorttagningBtn.UseVisualStyleBackColor = true;
            this.BorttagningBtn.Click += new System.EventHandler(this.BorttagningBtn_Click);
            // 
            // UtlämningBtn
            // 
            this.UtlämningBtn.Location = new System.Drawing.Point(50, 162);
            this.UtlämningBtn.Name = "UtlämningBtn";
            this.UtlämningBtn.Size = new System.Drawing.Size(200, 39);
            this.UtlämningBtn.TabIndex = 5;
            this.UtlämningBtn.Text = "Utlämning av böcker";
            this.UtlämningBtn.UseVisualStyleBackColor = true;
            // 
            // återlämningBtn
            // 
            this.återlämningBtn.Location = new System.Drawing.Point(50, 207);
            this.återlämningBtn.Name = "återlämningBtn";
            this.återlämningBtn.Size = new System.Drawing.Size(200, 39);
            this.återlämningBtn.TabIndex = 6;
            this.återlämningBtn.Text = "Återlämning av böcker";
            this.återlämningBtn.UseVisualStyleBackColor = true;
            // 
            // tillbakaBtn
            // 
            this.tillbakaBtn.Location = new System.Drawing.Point(13, 269);
            this.tillbakaBtn.Name = "tillbakaBtn";
            this.tillbakaBtn.Size = new System.Drawing.Size(123, 23);
            this.tillbakaBtn.TabIndex = 7;
            this.tillbakaBtn.Text = "Tillbaka till login-sidan";
            this.tillbakaBtn.UseVisualStyleBackColor = true;
            this.tillbakaBtn.Click += new System.EventHandler(this.tillbakaBtn_Click);
            // 
            // inloggadAnvändareLabel
            // 
            this.inloggadAnvändareLabel.AutoSize = true;
            this.inloggadAnvändareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inloggadAnvändareLabel.Location = new System.Drawing.Point(134, 24);
            this.inloggadAnvändareLabel.Name = "inloggadAnvändareLabel";
            this.inloggadAnvändareLabel.Size = new System.Drawing.Size(29, 20);
            this.inloggadAnvändareLabel.TabIndex = 8;
            this.inloggadAnvändareLabel.Text = "----";
            this.inloggadAnvändareLabel.Click += new System.EventHandler(this.inloggadAnvändareLabel_Click);
            // 
            // Meny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 304);
            this.ControlBox = false;
            this.Controls.Add(this.inloggadAnvändareLabel);
            this.Controls.Add(this.tillbakaBtn);
            this.Controls.Add(this.återlämningBtn);
            this.Controls.Add(this.UtlämningBtn);
            this.Controls.Add(this.BorttagningBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BokningBtn);
            this.Name = "Meny";
            this.Text = "Meny";
            this.Load += new System.EventHandler(this.Meny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BokningBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorttagningBtn;
        private System.Windows.Forms.Button UtlämningBtn;
        private System.Windows.Forms.Button återlämningBtn;
        private System.Windows.Forms.Button tillbakaBtn;
        private System.Windows.Forms.Label inloggadAnvändareLabel;
    }
}