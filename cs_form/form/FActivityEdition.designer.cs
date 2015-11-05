namespace MARS_perso
{
    partial class FActivityEdition
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
            this.B_cancel = new System.Windows.Forms.Button();
            this.B_save = new System.Windows.Forms.Button();
            this.L_Activity = new System.Windows.Forms.Label();
            this.list_activity = new System.Windows.Forms.ListBox();
            this.L_day = new System.Windows.Forms.Label();
            this.N_dateFrom = new System.Windows.Forms.NumericUpDown();
            this.L_dateFrom = new System.Windows.Forms.Label();
            this.N_dateHour = new System.Windows.Forms.NumericUpDown();
            this.L_hourFrom = new System.Windows.Forms.Label();
            this.N_dateMinute = new System.Windows.Forms.NumericUpDown();
            this.L_dateTo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.N_dateToMinute = new System.Windows.Forms.NumericUpDown();
            this.L_hourTo = new System.Windows.Forms.Label();
            this.L_astronuts = new System.Windows.Forms.Label();
            this.list_astronuts = new System.Windows.Forms.ListBox();
            this.L_description = new System.Windows.Forms.Label();
            this.T_description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // B_cancel
            // 
            this.B_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_cancel.Location = new System.Drawing.Point(270, 302);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(75, 23);
            this.B_cancel.TabIndex = 0;
            this.B_cancel.Text = "Cancel";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // B_save
            // 
            this.B_save.Location = new System.Drawing.Point(161, 302);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(75, 23);
            this.B_save.TabIndex = 1;
            this.B_save.Text = "Save";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // L_Activity
            // 
            this.L_Activity.AutoSize = true;
            this.L_Activity.Location = new System.Drawing.Point(69, 90);
            this.L_Activity.Name = "L_Activity";
            this.L_Activity.Size = new System.Drawing.Size(41, 13);
            this.L_Activity.TabIndex = 6;
            this.L_Activity.Text = "Activity";
            // 
            // list_activity
            // 
            this.list_activity.FormattingEnabled = true;
            this.list_activity.Location = new System.Drawing.Point(72, 106);
            this.list_activity.Name = "list_activity";
            this.list_activity.Size = new System.Drawing.Size(120, 17);
            this.list_activity.TabIndex = 7;
            // 
            // L_day
            // 
            this.L_day.AutoSize = true;
            this.L_day.Location = new System.Drawing.Point(69, 35);
            this.L_day.Name = "L_day";
            this.L_day.Size = new System.Drawing.Size(26, 13);
            this.L_day.TabIndex = 11;
            this.L_day.Text = "Day";
            // 
            // N_dateFrom
            // 
            this.N_dateFrom.Location = new System.Drawing.Point(101, 33);
            this.N_dateFrom.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.N_dateFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_dateFrom.Name = "N_dateFrom";
            this.N_dateFrom.Size = new System.Drawing.Size(35, 20);
            this.N_dateFrom.TabIndex = 18;
            this.N_dateFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // L_dateFrom
            // 
            this.L_dateFrom.AutoSize = true;
            this.L_dateFrom.Location = new System.Drawing.Point(190, 35);
            this.L_dateFrom.Name = "L_dateFrom";
            this.L_dateFrom.Size = new System.Drawing.Size(30, 13);
            this.L_dateFrom.TabIndex = 19;
            this.L_dateFrom.Text = "From";
            // 
            // N_dateHour
            // 
            this.N_dateHour.Location = new System.Drawing.Point(226, 33);
            this.N_dateHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_dateHour.Name = "N_dateHour";
            this.N_dateHour.Size = new System.Drawing.Size(35, 20);
            this.N_dateHour.TabIndex = 20;
            // 
            // L_hourFrom
            // 
            this.L_hourFrom.AutoSize = true;
            this.L_hourFrom.Location = new System.Drawing.Point(267, 35);
            this.L_hourFrom.Name = "L_hourFrom";
            this.L_hourFrom.Size = new System.Drawing.Size(15, 13);
            this.L_hourFrom.TabIndex = 22;
            this.L_hourFrom.Text = "H";
            // 
            // N_dateMinute
            // 
            this.N_dateMinute.Location = new System.Drawing.Point(288, 33);
            this.N_dateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateMinute.Name = "N_dateMinute";
            this.N_dateMinute.Size = new System.Drawing.Size(35, 20);
            this.N_dateMinute.TabIndex = 24;
            // 
            // L_dateTo
            // 
            this.L_dateTo.AutoSize = true;
            this.L_dateTo.Location = new System.Drawing.Point(190, 63);
            this.L_dateTo.Name = "L_dateTo";
            this.L_dateTo.Size = new System.Drawing.Size(20, 13);
            this.L_dateTo.TabIndex = 25;
            this.L_dateTo.Text = "To";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(226, 61);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 26;
            // 
            // N_dateToMinute
            // 
            this.N_dateToMinute.Location = new System.Drawing.Point(288, 61);
            this.N_dateToMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateToMinute.Name = "N_dateToMinute";
            this.N_dateToMinute.Size = new System.Drawing.Size(35, 20);
            this.N_dateToMinute.TabIndex = 27;
            // 
            // L_hourTo
            // 
            this.L_hourTo.AutoSize = true;
            this.L_hourTo.Location = new System.Drawing.Point(267, 63);
            this.L_hourTo.Name = "L_hourTo";
            this.L_hourTo.Size = new System.Drawing.Size(15, 13);
            this.L_hourTo.TabIndex = 28;
            this.L_hourTo.Text = "H";
            // 
            // L_astronuts
            // 
            this.L_astronuts.AutoSize = true;
            this.L_astronuts.Location = new System.Drawing.Point(69, 140);
            this.L_astronuts.Name = "L_astronuts";
            this.L_astronuts.Size = new System.Drawing.Size(51, 13);
            this.L_astronuts.TabIndex = 29;
            this.L_astronuts.Text = "Astronuts";
            // 
            // list_astronuts
            // 
            this.list_astronuts.FormattingEnabled = true;
            this.list_astronuts.Location = new System.Drawing.Point(72, 156);
            this.list_astronuts.Name = "list_astronuts";
            this.list_astronuts.Size = new System.Drawing.Size(120, 17);
            this.list_astronuts.TabIndex = 30;
            // 
            // L_description
            // 
            this.L_description.AutoSize = true;
            this.L_description.Location = new System.Drawing.Point(69, 198);
            this.L_description.Name = "L_description";
            this.L_description.Size = new System.Drawing.Size(60, 13);
            this.L_description.TabIndex = 31;
            this.L_description.Text = "Description";
            // 
            // T_description
            // 
            this.T_description.Location = new System.Drawing.Point(72, 214);
            this.T_description.Name = "T_description";
            this.T_description.Size = new System.Drawing.Size(300, 20);
            this.T_description.TabIndex = 32;
            // 
            // FActivityEdition
            // 
            this.AcceptButton = this.B_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_cancel;
            this.ClientSize = new System.Drawing.Size(512, 353);
            this.Controls.Add(this.T_description);
            this.Controls.Add(this.L_description);
            this.Controls.Add(this.list_astronuts);
            this.Controls.Add(this.L_astronuts);
            this.Controls.Add(this.L_hourTo);
            this.Controls.Add(this.N_dateToMinute);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.L_dateTo);
            this.Controls.Add(this.N_dateMinute);
            this.Controls.Add(this.L_hourFrom);
            this.Controls.Add(this.N_dateHour);
            this.Controls.Add(this.L_dateFrom);
            this.Controls.Add(this.N_dateFrom);
            this.Controls.Add(this.L_day);
            this.Controls.Add(this.list_activity);
            this.Controls.Add(this.L_Activity);
            this.Controls.Add(this.B_save);
            this.Controls.Add(this.B_cancel);
            this.Name = "FActivityEdition";
            this.Text = "FActivityEdition";
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_cancel;
        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.Label L_Activity;
        private System.Windows.Forms.ListBox list_activity;
        private System.Windows.Forms.Label L_day;
        private System.Windows.Forms.NumericUpDown N_dateFrom;
        private System.Windows.Forms.Label L_dateFrom;
        private System.Windows.Forms.NumericUpDown N_dateHour;
        private System.Windows.Forms.Label L_hourFrom;
        private System.Windows.Forms.NumericUpDown N_dateMinute;
        private System.Windows.Forms.Label L_dateTo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown N_dateToMinute;
        private System.Windows.Forms.Label L_hourTo;
        private System.Windows.Forms.Label L_astronuts;
        private System.Windows.Forms.ListBox list_astronuts;
        private System.Windows.Forms.Label L_description;
        private System.Windows.Forms.TextBox T_description;

    }
}