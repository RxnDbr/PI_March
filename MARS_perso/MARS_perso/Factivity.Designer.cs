namespace MARS_perso
{
    partial class Factivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factivity));
            this.P_addActivity = new System.Windows.Forms.PictureBox();
            this.L_day = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_addActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // P_addActivity
            // 
            this.P_addActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_addActivity.Image = ((System.Drawing.Image)(resources.GetObject("P_addActivity.Image")));
            this.P_addActivity.Location = new System.Drawing.Point(384, 12);
            this.P_addActivity.Name = "P_addActivity";
            this.P_addActivity.Size = new System.Drawing.Size(34, 32);
            this.P_addActivity.TabIndex = 4;
            this.P_addActivity.TabStop = false;
            this.P_addActivity.Click += new System.EventHandler(this.P_addActivity_Click);
            // 
            // L_day
            // 
            this.L_day.AutoSize = true;
            this.L_day.Location = new System.Drawing.Point(99, 93);
            this.L_day.Name = "L_day";
            this.L_day.Size = new System.Drawing.Size(37, 13);
            this.L_day.TabIndex = 5;
            this.L_day.Text = "Jour X";
            // 
            // Factivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 406);
            this.ControlBox = false;
            this.Controls.Add(this.L_day);
            this.Controls.Add(this.P_addActivity);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factivity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.P_addActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_addActivity;
        private System.Windows.Forms.Label L_day;
    }
}