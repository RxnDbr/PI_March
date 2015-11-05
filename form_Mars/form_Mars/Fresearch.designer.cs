namespace MARS_perso
{
    partial class Fresearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fresearch));
            this.P_calendar = new System.Windows.Forms.PictureBox();
            this.L_research = new System.Windows.Forms.Label();
            this.L_Activity = new System.Windows.Forms.Label();
            this.list_activity = new System.Windows.Forms.ListBox();
            this.L_researchByContent = new System.Windows.Forms.Label();
            this.T_searchByContent = new System.Windows.Forms.TextBox();
            this.L_dateFrom = new System.Windows.Forms.Label();
            this.L_day = new System.Windows.Forms.Label();
            this.L_dateTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_dateAt = new System.Windows.Forms.Label();
            this.N_dateHour = new System.Windows.Forms.NumericUpDown();
            this.N_dateFrom = new System.Windows.Forms.NumericUpDown();
            this.N_dateTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.L_hour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.N_dateMinute = new System.Windows.Forms.NumericUpDown();
            this.N_dateToMinute = new System.Windows.Forms.NumericUpDown();
            this.B_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.P_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // P_calendar
            // 
            this.P_calendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_calendar.Image = ((System.Drawing.Image)(resources.GetObject("P_calendar.Image")));
            this.P_calendar.Location = new System.Drawing.Point(182, 12);
            this.P_calendar.Name = "P_calendar";
            this.P_calendar.Size = new System.Drawing.Size(37, 32);
            this.P_calendar.TabIndex = 3;
            this.P_calendar.TabStop = false;
            this.P_calendar.Click += new System.EventHandler(this.P_calendar_Click);
            // 
            // L_research
            // 
            this.L_research.AutoSize = true;
            this.L_research.Location = new System.Drawing.Point(12, 31);
            this.L_research.Name = "L_research";
            this.L_research.Size = new System.Drawing.Size(53, 13);
            this.L_research.TabIndex = 4;
            this.L_research.Text = "Research";
            // 
            // L_Activity
            // 
            this.L_Activity.AutoSize = true;
            this.L_Activity.Location = new System.Drawing.Point(42, 68);
            this.L_Activity.Name = "L_Activity";
            this.L_Activity.Size = new System.Drawing.Size(41, 13);
            this.L_Activity.TabIndex = 5;
            this.L_Activity.Text = "Activity";
            // 
            // list_activity
            // 
            this.list_activity.FormattingEnabled = true;
            this.list_activity.Location = new System.Drawing.Point(45, 84);
            this.list_activity.Name = "list_activity";
            this.list_activity.Size = new System.Drawing.Size(120, 17);
            this.list_activity.TabIndex = 6;
            // 
            // L_researchByContent
            // 
            this.L_researchByContent.AutoSize = true;
            this.L_researchByContent.Location = new System.Drawing.Point(42, 118);
            this.L_researchByContent.Name = "L_researchByContent";
            this.L_researchByContent.Size = new System.Drawing.Size(94, 13);
            this.L_researchByContent.TabIndex = 7;
            this.L_researchByContent.Text = "Search by content";
            // 
            // T_searchByContent
            // 
            this.T_searchByContent.Location = new System.Drawing.Point(45, 135);
            this.T_searchByContent.Name = "T_searchByContent";
            this.T_searchByContent.Size = new System.Drawing.Size(100, 20);
            this.T_searchByContent.TabIndex = 8;
            // 
            // L_dateFrom
            // 
            this.L_dateFrom.AutoSize = true;
            this.L_dateFrom.Location = new System.Drawing.Point(45, 175);
            this.L_dateFrom.Name = "L_dateFrom";
            this.L_dateFrom.Size = new System.Drawing.Size(30, 13);
            this.L_dateFrom.TabIndex = 9;
            this.L_dateFrom.Text = "From";
            // 
            // L_day
            // 
            this.L_day.AutoSize = true;
            this.L_day.Location = new System.Drawing.Point(45, 192);
            this.L_day.Name = "L_day";
            this.L_day.Size = new System.Drawing.Size(26, 13);
            this.L_day.TabIndex = 10;
            this.L_day.Text = "Day";
            // 
            // L_dateTo
            // 
            this.L_dateTo.AutoSize = true;
            this.L_dateTo.Location = new System.Drawing.Point(235, 175);
            this.L_dateTo.Name = "L_dateTo";
            this.L_dateTo.Size = new System.Drawing.Size(20, 13);
            this.L_dateTo.TabIndex = 12;
            this.L_dateTo.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Day";
            // 
            // L_dateAt
            // 
            this.L_dateAt.AutoSize = true;
            this.L_dateAt.Location = new System.Drawing.Point(45, 215);
            this.L_dateAt.Name = "L_dateAt";
            this.L_dateAt.Size = new System.Drawing.Size(17, 13);
            this.L_dateAt.TabIndex = 15;
            this.L_dateAt.Text = "At";
            // 
            // N_dateHour
            // 
            this.N_dateHour.Location = new System.Drawing.Point(68, 213);
            this.N_dateHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_dateHour.Name = "N_dateHour";
            this.N_dateHour.Size = new System.Drawing.Size(35, 20);
            this.N_dateHour.TabIndex = 16;
            // 
            // N_dateFrom
            // 
            this.N_dateFrom.Location = new System.Drawing.Point(77, 190);
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
            this.N_dateFrom.TabIndex = 17;
            this.N_dateFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // N_dateTo
            // 
            this.N_dateTo.Location = new System.Drawing.Point(267, 190);
            this.N_dateTo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.N_dateTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_dateTo.Name = "N_dateTo";
            this.N_dateTo.Size = new System.Drawing.Size(35, 20);
            this.N_dateTo.TabIndex = 18;
            this.N_dateTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "At";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 218);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // L_hour
            // 
            this.L_hour.AutoSize = true;
            this.L_hour.Location = new System.Drawing.Point(109, 215);
            this.L_hour.Name = "L_hour";
            this.L_hour.Size = new System.Drawing.Size(15, 13);
            this.L_hour.TabIndex = 21;
            this.L_hour.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "H";
            // 
            // N_dateMinute
            // 
            this.N_dateMinute.Location = new System.Drawing.Point(130, 213);
            this.N_dateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateMinute.Name = "N_dateMinute";
            this.N_dateMinute.Size = new System.Drawing.Size(35, 20);
            this.N_dateMinute.TabIndex = 23;
            // 
            // N_dateToMinute
            // 
            this.N_dateToMinute.Location = new System.Drawing.Point(320, 218);
            this.N_dateToMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateToMinute.Name = "N_dateToMinute";
            this.N_dateToMinute.Size = new System.Drawing.Size(35, 20);
            this.N_dateToMinute.TabIndex = 24;
            // 
            // B_search
            // 
            this.B_search.Location = new System.Drawing.Point(163, 257);
            this.B_search.Name = "B_search";
            this.B_search.Size = new System.Drawing.Size(75, 23);
            this.B_search.TabIndex = 25;
            this.B_search.Text = "Search";
            this.B_search.UseVisualStyleBackColor = true;
            // 
            // Fresearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 292);
            this.ControlBox = false;
            this.Controls.Add(this.B_search);
            this.Controls.Add(this.N_dateToMinute);
            this.Controls.Add(this.N_dateMinute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_hour);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N_dateTo);
            this.Controls.Add(this.N_dateFrom);
            this.Controls.Add(this.N_dateHour);
            this.Controls.Add(this.L_dateAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_dateTo);
            this.Controls.Add(this.L_day);
            this.Controls.Add(this.L_dateFrom);
            this.Controls.Add(this.T_searchByContent);
            this.Controls.Add(this.L_researchByContent);
            this.Controls.Add(this.list_activity);
            this.Controls.Add(this.L_Activity);
            this.Controls.Add(this.L_research);
            this.Controls.Add(this.P_calendar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fresearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fresearch";
            ((System.ComponentModel.ISupportInitialize)(this.P_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_calendar;
        private System.Windows.Forms.Label L_research;
        private System.Windows.Forms.Label L_Activity;
        private System.Windows.Forms.ListBox list_activity;
        private System.Windows.Forms.Label L_researchByContent;
        private System.Windows.Forms.TextBox T_searchByContent;
        private System.Windows.Forms.Label L_dateFrom;
        private System.Windows.Forms.Label L_day;
        private System.Windows.Forms.Label L_dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_dateAt;
        private System.Windows.Forms.NumericUpDown N_dateHour;
        private System.Windows.Forms.NumericUpDown N_dateFrom;
        private System.Windows.Forms.NumericUpDown N_dateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label L_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown N_dateMinute;
        private System.Windows.Forms.NumericUpDown N_dateToMinute;
        private System.Windows.Forms.Button B_search;
    }
}