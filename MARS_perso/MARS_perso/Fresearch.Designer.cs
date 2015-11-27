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
            this.L_Activity = new System.Windows.Forms.Label();
            this.list_activity = new System.Windows.Forms.ListBox();
            this.L_researchByContent = new System.Windows.Forms.Label();
            this.T_searchByContent = new System.Windows.Forms.TextBox();
            this.L_dateFrom = new System.Windows.Forms.Label();
            this.L_dayFrom = new System.Windows.Forms.Label();
            this.L_dateTo = new System.Windows.Forms.Label();
            this.L_dayTo = new System.Windows.Forms.Label();
            this.N_dateFrom = new System.Windows.Forms.NumericUpDown();
            this.N_dateTo = new System.Windows.Forms.NumericUpDown();
            this.B_search = new System.Windows.Forms.Button();
            this.L_error = new System.Windows.Forms.Label();
            this.B_emptyFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateTo)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Activity
            // 
            this.L_Activity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Activity.AutoSize = true;
            this.L_Activity.Location = new System.Drawing.Point(42, 68);
            this.L_Activity.Name = "L_Activity";
            this.L_Activity.Size = new System.Drawing.Size(41, 13);
            this.L_Activity.TabIndex = 5;
            this.L_Activity.Text = "Activity";
            // 
            // list_activity
            // 
            this.list_activity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.list_activity.FormattingEnabled = true;
            this.list_activity.Location = new System.Drawing.Point(45, 84);
            this.list_activity.Name = "list_activity";
            this.list_activity.Size = new System.Drawing.Size(120, 17);
            this.list_activity.TabIndex = 6;
            // 
            // L_researchByContent
            // 
            this.L_researchByContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_researchByContent.AutoSize = true;
            this.L_researchByContent.Location = new System.Drawing.Point(42, 118);
            this.L_researchByContent.Name = "L_researchByContent";
            this.L_researchByContent.Size = new System.Drawing.Size(149, 13);
            this.L_researchByContent.TabIndex = 7;
            this.L_researchByContent.Text = "Contient le mot ou l\'expression";
            // 
            // T_searchByContent
            // 
            this.T_searchByContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.T_searchByContent.Location = new System.Drawing.Point(45, 135);
            this.T_searchByContent.Name = "T_searchByContent";
            this.T_searchByContent.Size = new System.Drawing.Size(146, 20);
            this.T_searchByContent.TabIndex = 8;
            // 
            // L_dateFrom
            // 
            this.L_dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dateFrom.AutoSize = true;
            this.L_dateFrom.Location = new System.Drawing.Point(28, 192);
            this.L_dateFrom.Name = "L_dateFrom";
            this.L_dateFrom.Size = new System.Drawing.Size(55, 13);
            this.L_dateFrom.TabIndex = 9;
            this.L_dateFrom.Text = "A partir du";
            // 
            // L_dayFrom
            // 
            this.L_dayFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dayFrom.AutoSize = true;
            this.L_dayFrom.Location = new System.Drawing.Point(28, 209);
            this.L_dayFrom.Name = "L_dayFrom";
            this.L_dayFrom.Size = new System.Drawing.Size(27, 13);
            this.L_dayFrom.TabIndex = 10;
            this.L_dayFrom.Text = "Jour";
            // 
            // L_dateTo
            // 
            this.L_dateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dateTo.AutoSize = true;
            this.L_dateTo.Location = new System.Drawing.Point(145, 192);
            this.L_dateTo.Name = "L_dateTo";
            this.L_dateTo.Size = new System.Drawing.Size(49, 13);
            this.L_dateTo.TabIndex = 12;
            this.L_dateTo.Text = "Jusqu\'au";
            // 
            // L_dayTo
            // 
            this.L_dayTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dayTo.AutoSize = true;
            this.L_dayTo.Location = new System.Drawing.Point(145, 209);
            this.L_dayTo.Name = "L_dayTo";
            this.L_dayTo.Size = new System.Drawing.Size(27, 13);
            this.L_dayTo.TabIndex = 13;
            this.L_dayTo.Text = "Jour";
            // 
            // N_dateFrom
            // 
            this.N_dateFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.N_dateFrom.Location = new System.Drawing.Point(60, 207);
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
            this.N_dateFrom.ValueChanged += new System.EventHandler(this.N_dateFrom_ValueChanged);
            // 
            // N_dateTo
            // 
            this.N_dateTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.N_dateTo.Location = new System.Drawing.Point(177, 207);
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
            this.N_dateTo.ValueChanged += new System.EventHandler(this.N_dateTo_ValueChanged);
            // 
            // B_search
            // 
            this.B_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_search.Location = new System.Drawing.Point(148, 257);
            this.B_search.Name = "B_search";
            this.B_search.Size = new System.Drawing.Size(105, 23);
            this.B_search.TabIndex = 25;
            this.B_search.Text = "Rechercher";
            this.B_search.UseVisualStyleBackColor = true;
            this.B_search.Click += new System.EventHandler(this.B_search_Click);
            // 
            // L_error
            // 
            this.L_error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_error.AutoSize = true;
            this.L_error.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.L_error.ForeColor = System.Drawing.Color.Red;
            this.L_error.Location = new System.Drawing.Point(28, 179);
            this.L_error.Name = "L_error";
            this.L_error.Size = new System.Drawing.Size(14, 13);
            this.L_error.TabIndex = 26;
            this.L_error.Text = "* ";
            // 
            // B_emptyFields
            // 
            this.B_emptyFields.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_emptyFields.Location = new System.Drawing.Point(31, 257);
            this.B_emptyFields.Name = "B_emptyFields";
            this.B_emptyFields.Size = new System.Drawing.Size(105, 23);
            this.B_emptyFields.TabIndex = 27;
            this.B_emptyFields.Text = "Vider les champs";
            this.B_emptyFields.UseVisualStyleBackColor = true;
            this.B_emptyFields.Click += new System.EventHandler(this.B_emptyFields_Click);
            // 
            // Fresearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 292);
            this.ControlBox = false;
            this.Controls.Add(this.B_emptyFields);
            this.Controls.Add(this.L_error);
            this.Controls.Add(this.B_search);
            this.Controls.Add(this.N_dateTo);
            this.Controls.Add(this.N_dateFrom);
            this.Controls.Add(this.L_dayTo);
            this.Controls.Add(this.L_dateTo);
            this.Controls.Add(this.L_dayFrom);
            this.Controls.Add(this.L_dateFrom);
            this.Controls.Add(this.T_searchByContent);
            this.Controls.Add(this.L_researchByContent);
            this.Controls.Add(this.list_activity);
            this.Controls.Add(this.L_Activity);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fresearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fresearch";
            ((System.ComponentModel.ISupportInitialize)(this.N_dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Activity;
        private System.Windows.Forms.ListBox list_activity;
        private System.Windows.Forms.Label L_researchByContent;
        private System.Windows.Forms.TextBox T_searchByContent;
        private System.Windows.Forms.Label L_dateFrom;
        private System.Windows.Forms.Label L_dayFrom;
        private System.Windows.Forms.Label L_dateTo;
        private System.Windows.Forms.Label L_dayTo;
        private System.Windows.Forms.NumericUpDown N_dateFrom;
        private System.Windows.Forms.NumericUpDown N_dateTo;
        private System.Windows.Forms.Button B_search;
        private System.Windows.Forms.Label L_error;
        private System.Windows.Forms.Button B_emptyFields;
    }
}