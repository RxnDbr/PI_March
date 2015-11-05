namespace MARS_perso
{
    partial class Finitialization
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
            this.L_dayOnMars = new System.Windows.Forms.Label();
            this.N_dayOnMars = new System.Windows.Forms.NumericUpDown();
            this.N_hourOnMars = new System.Windows.Forms.NumericUpDown();
            this.L_hourOnMars = new System.Windows.Forms.Label();
            this.N_minuteOnMars = new System.Windows.Forms.NumericUpDown();
            this.L_dateAndTimeOnMars = new System.Windows.Forms.Label();
            this.L_dateAndTimeOnEarth = new System.Windows.Forms.Label();
            this.N_minuteOnEarth = new System.Windows.Forms.NumericUpDown();
            this.L_hourOnEarth = new System.Windows.Forms.Label();
            this.N_hourOnEarth = new System.Windows.Forms.NumericUpDown();
            this.N_dayOnEarth = new System.Windows.Forms.NumericUpDown();
            this.L_dayOnEarth = new System.Windows.Forms.Label();
            this.B_validate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.N_dayOnMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dayOnEarth)).BeginInit();
            this.SuspendLayout();
            // 
            // L_dayOnMars
            // 
            this.L_dayOnMars.AutoSize = true;
            this.L_dayOnMars.Location = new System.Drawing.Point(91, 142);
            this.L_dayOnMars.Name = "L_dayOnMars";
            this.L_dayOnMars.Size = new System.Drawing.Size(26, 13);
            this.L_dayOnMars.TabIndex = 11;
            this.L_dayOnMars.Text = "Day";
            // 
            // N_dayOnMars
            // 
            this.N_dayOnMars.Location = new System.Drawing.Point(123, 140);
            this.N_dayOnMars.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.N_dayOnMars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_dayOnMars.Name = "N_dayOnMars";
            this.N_dayOnMars.Size = new System.Drawing.Size(35, 20);
            this.N_dayOnMars.TabIndex = 18;
            this.N_dayOnMars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // N_hourOnMars
            // 
            this.N_hourOnMars.Location = new System.Drawing.Point(198, 140);
            this.N_hourOnMars.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_hourOnMars.Name = "N_hourOnMars";
            this.N_hourOnMars.Size = new System.Drawing.Size(35, 20);
            this.N_hourOnMars.TabIndex = 19;
            // 
            // L_hourOnMars
            // 
            this.L_hourOnMars.AutoSize = true;
            this.L_hourOnMars.Location = new System.Drawing.Point(239, 142);
            this.L_hourOnMars.Name = "L_hourOnMars";
            this.L_hourOnMars.Size = new System.Drawing.Size(15, 13);
            this.L_hourOnMars.TabIndex = 22;
            this.L_hourOnMars.Text = "H";
            // 
            // N_minuteOnMars
            // 
            this.N_minuteOnMars.Location = new System.Drawing.Point(260, 140);
            this.N_minuteOnMars.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_minuteOnMars.Name = "N_minuteOnMars";
            this.N_minuteOnMars.Size = new System.Drawing.Size(35, 20);
            this.N_minuteOnMars.TabIndex = 24;
            // 
            // L_dateAndTimeOnMars
            // 
            this.L_dateAndTimeOnMars.AutoSize = true;
            this.L_dateAndTimeOnMars.Location = new System.Drawing.Point(94, 112);
            this.L_dateAndTimeOnMars.Name = "L_dateAndTimeOnMars";
            this.L_dateAndTimeOnMars.Size = new System.Drawing.Size(118, 13);
            this.L_dateAndTimeOnMars.TabIndex = 25;
            this.L_dateAndTimeOnMars.Text = "Date and Time on Mars";
            // 
            // L_dateAndTimeOnEarth
            // 
            this.L_dateAndTimeOnEarth.AutoSize = true;
            this.L_dateAndTimeOnEarth.Location = new System.Drawing.Point(94, 188);
            this.L_dateAndTimeOnEarth.Name = "L_dateAndTimeOnEarth";
            this.L_dateAndTimeOnEarth.Size = new System.Drawing.Size(171, 13);
            this.L_dateAndTimeOnEarth.TabIndex = 31;
            this.L_dateAndTimeOnEarth.Text = "Date and Time equivalent on earth";
            // 
            // N_minuteOnEarth
            // 
            this.N_minuteOnEarth.Location = new System.Drawing.Point(260, 216);
            this.N_minuteOnEarth.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_minuteOnEarth.Name = "N_minuteOnEarth";
            this.N_minuteOnEarth.Size = new System.Drawing.Size(35, 20);
            this.N_minuteOnEarth.TabIndex = 30;
            // 
            // L_hourOnEarth
            // 
            this.L_hourOnEarth.AutoSize = true;
            this.L_hourOnEarth.Location = new System.Drawing.Point(239, 218);
            this.L_hourOnEarth.Name = "L_hourOnEarth";
            this.L_hourOnEarth.Size = new System.Drawing.Size(15, 13);
            this.L_hourOnEarth.TabIndex = 29;
            this.L_hourOnEarth.Text = "H";
            // 
            // N_hourOnEarth
            // 
            this.N_hourOnEarth.Location = new System.Drawing.Point(198, 216);
            this.N_hourOnEarth.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_hourOnEarth.Name = "N_hourOnEarth";
            this.N_hourOnEarth.Size = new System.Drawing.Size(35, 20);
            this.N_hourOnEarth.TabIndex = 28;
            // 
            // N_dayOnEarth
            // 
            this.N_dayOnEarth.Location = new System.Drawing.Point(123, 216);
            this.N_dayOnEarth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.N_dayOnEarth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_dayOnEarth.Name = "N_dayOnEarth";
            this.N_dayOnEarth.Size = new System.Drawing.Size(35, 20);
            this.N_dayOnEarth.TabIndex = 27;
            this.N_dayOnEarth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // L_dayOnEarth
            // 
            this.L_dayOnEarth.AutoSize = true;
            this.L_dayOnEarth.Location = new System.Drawing.Point(91, 218);
            this.L_dayOnEarth.Name = "L_dayOnEarth";
            this.L_dayOnEarth.Size = new System.Drawing.Size(26, 13);
            this.L_dayOnEarth.TabIndex = 26;
            this.L_dayOnEarth.Text = "Day";
            // 
            // B_validate
            // 
            this.B_validate.Location = new System.Drawing.Point(179, 273);
            this.B_validate.Name = "B_validate";
            this.B_validate.Size = new System.Drawing.Size(75, 23);
            this.B_validate.TabIndex = 32;
            this.B_validate.Text = "Validate";
            this.B_validate.UseVisualStyleBackColor = true;
            this.B_validate.Click += new System.EventHandler(this.B_validate_Click);
            // 
            // Finitialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 325);
            this.Controls.Add(this.B_validate);
            this.Controls.Add(this.L_dateAndTimeOnEarth);
            this.Controls.Add(this.N_minuteOnEarth);
            this.Controls.Add(this.L_hourOnEarth);
            this.Controls.Add(this.N_hourOnEarth);
            this.Controls.Add(this.N_dayOnEarth);
            this.Controls.Add(this.L_dayOnEarth);
            this.Controls.Add(this.L_dateAndTimeOnMars);
            this.Controls.Add(this.N_minuteOnMars);
            this.Controls.Add(this.L_hourOnMars);
            this.Controls.Add(this.N_hourOnMars);
            this.Controls.Add(this.N_dayOnMars);
            this.Controls.Add(this.L_dayOnMars);
            this.Name = "Finitialization";
            this.Text = "Finitialization";
            ((System.ComponentModel.ISupportInitialize)(this.N_dayOnMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dayOnEarth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_dayOnMars;
        private System.Windows.Forms.NumericUpDown N_dayOnMars;
        private System.Windows.Forms.NumericUpDown N_hourOnMars;
        private System.Windows.Forms.Label L_hourOnMars;
        private System.Windows.Forms.NumericUpDown N_minuteOnMars;
        private System.Windows.Forms.Label L_dateAndTimeOnMars;
        private System.Windows.Forms.Label L_dateAndTimeOnEarth;
        private System.Windows.Forms.NumericUpDown N_minuteOnEarth;
        private System.Windows.Forms.Label L_hourOnEarth;
        private System.Windows.Forms.NumericUpDown N_hourOnEarth;
        private System.Windows.Forms.NumericUpDown N_dayOnEarth;
        private System.Windows.Forms.Label L_dayOnEarth;
        private System.Windows.Forms.Button B_validate;
    }
}