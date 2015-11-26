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
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcontainer));
            this.L_date = new System.Windows.Forms.Label();
            this.P_research = new System.Windows.Forms.PictureBox();
            this.P_astronaute = new System.Windows.Forms.PictureBox();
            this.P_calendar = new System.Windows.Forms.PictureBox();
            this.P_settings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P_research)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_astronaute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_settings)).BeginInit();
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
            this.L_date.Click += new System.EventHandler(this.L_date_Click);
            // 
            // P_research
            // 
            this.P_research.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_research.Image = ((System.Drawing.Image)(resources.GetObject("P_research.Image")));
            this.P_research.Location = new System.Drawing.Point(344, 12);
            this.P_research.Name = "P_research";
            this.P_research.Size = new System.Drawing.Size(31, 33);
            this.P_research.TabIndex = 7;
            this.P_research.TabStop = false;
            this.P_research.Click += new System.EventHandler(this.P_research_Click);
            // 
            // P_astronaute
            // 
            this.P_astronaute.AccessibleName = "P_astronaute";
            this.P_astronaute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_astronaute.Image = ((System.Drawing.Image)(resources.GetObject("P_astronaute.Image")));
            this.P_astronaute.Location = new System.Drawing.Point(381, 12);
            this.P_astronaute.Name = "P_astronaute";
            this.P_astronaute.Size = new System.Drawing.Size(31, 34);
            this.P_astronaute.TabIndex = 8;
            this.P_astronaute.TabStop = false;
            this.P_astronaute.Click += new System.EventHandler(this.P_astronaute_Click);
            // 
            // P_calendar
            // 
            this.P_calendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_calendar.Image = ((System.Drawing.Image)(resources.GetObject("P_calendar.Image")));
            this.P_calendar.Location = new System.Drawing.Point(202, 14);
            this.P_calendar.Name = "P_calendar";
            this.P_calendar.Size = new System.Drawing.Size(37, 32);
            this.P_calendar.TabIndex = 10;
            this.P_calendar.TabStop = false;
            this.P_calendar.Click += new System.EventHandler(this.P_calendar_Click);
            // 
            // P_settings
            // 
            this.P_settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_settings.Image = ((System.Drawing.Image)(resources.GetObject("P_settings.Image")));
            this.P_settings.Location = new System.Drawing.Point(202, 14);
            this.P_settings.Name = "P_settings";
            this.P_settings.Size = new System.Drawing.Size(37, 32);
            this.P_settings.TabIndex = 12;
            this.P_settings.TabStop = false;
            this.P_settings.Click += new System.EventHandler(this.P_settings_Click);
            // 
            // Fcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.P_settings);
            this.Controls.Add(this.P_calendar);
            this.Controls.Add(this.P_astronaute);
            this.Controls.Add(this.P_research);
            this.Controls.Add(this.L_date);
            this.MinimumSize = new System.Drawing.Size(50, 100);
            this.Name = "Fcontainer";
            this.Text = "Container";
            this.AutoSizeChanged += new System.EventHandler(this.Fcontainer_AutoSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.P_research)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_astronaute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_date;
        private System.Windows.Forms.PictureBox P_research;
        private System.Windows.Forms.PictureBox P_astronaute;
        private System.Windows.Forms.PictureBox P_calendar;
        private System.Windows.Forms.PictureBox P_settings;
    }
}