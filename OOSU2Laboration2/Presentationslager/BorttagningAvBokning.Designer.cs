namespace Presentationslager
{
    partial class BorttagningAvBokning
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
            this.BokningAttTaBortcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BokningAttTaBortcomboBox
            // 
            this.BokningAttTaBortcomboBox.FormattingEnabled = true;
            this.BokningAttTaBortcomboBox.Location = new System.Drawing.Point(99, 12);
            this.BokningAttTaBortcomboBox.Name = "BokningAttTaBortcomboBox";
            this.BokningAttTaBortcomboBox.Size = new System.Drawing.Size(217, 21);
            this.BokningAttTaBortcomboBox.TabIndex = 0;
            this.BokningAttTaBortcomboBox.SelectedIndexChanged += new System.EventHandler(this.BokningAttTaBortcomboBox_SelectedIndexChanged);
            // 
            // BorttagningAvBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BokningAttTaBortcomboBox);
            this.Name = "BorttagningAvBokning";
            this.Text = "BorttagningAvBokning";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BokningAttTaBortcomboBox;
    }
}