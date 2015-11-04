namespace MARS_perso
{
    partial class Fcontainer
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
            this.L_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_date
            // 
            this.L_date.AutoSize = true;
            this.L_date.Location = new System.Drawing.Point(12, 9);
            this.L_date.Name = "L_date";
            this.L_date.Size = new System.Drawing.Size(63, 13);
            this.L_date.TabIndex = 2;
            this.L_date.Text = "Jour X, XhX";
            // 
            // Fcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.L_date);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(50, 100);
            this.Name = "Fcontainer";
            this.Text = "Container";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_date;
    }
}