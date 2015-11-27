namespace MARS_perso
{
    partial class Fsettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsettings));
            this.N_hourOnEarth = new System.Windows.Forms.NumericUpDown();
            this.L_hourOnEarth = new System.Windows.Forms.Label();
            this.N_minuteOnEarth = new System.Windows.Forms.NumericUpDown();
            this.B_update = new System.Windows.Forms.Button();
            this.P_earth = new System.Windows.Forms.PictureBox();
            this.P_mars = new System.Windows.Forms.PictureBox();
            this.L_dayOnMars = new System.Windows.Forms.Label();
            this.L_dayOnEarth = new System.Windows.Forms.Label();
            this.L_missionDuration = new System.Windows.Forms.Label();
            this.L_listAstronauts = new System.Windows.Forms.Label();
            this.P_MissionEdition = new System.Windows.Forms.PictureBox();
            this.P_LinkingHours = new System.Windows.Forms.Panel();
            this.L_LinkingHours = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.P_AstronutsEdition = new System.Windows.Forms.PictureBox();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_mars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_MissionEdition)).BeginInit();
            this.P_LinkingHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_AstronutsEdition)).BeginInit();
            this.SuspendLayout();
            // 
            // N_hourOnEarth
            // 
            this.N_hourOnEarth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.N_hourOnEarth.Location = new System.Drawing.Point(334, 45);
            this.N_hourOnEarth.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_hourOnEarth.Name = "N_hourOnEarth";
            this.N_hourOnEarth.Size = new System.Drawing.Size(35, 20);
            this.N_hourOnEarth.TabIndex = 19;
            // 
            // L_hourOnEarth
            // 
            this.L_hourOnEarth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.L_hourOnEarth.AutoSize = true;
            this.L_hourOnEarth.Location = new System.Drawing.Point(370, 47);
            this.L_hourOnEarth.Name = "L_hourOnEarth";
            this.L_hourOnEarth.Size = new System.Drawing.Size(15, 13);
            this.L_hourOnEarth.TabIndex = 22;
            this.L_hourOnEarth.Text = "H";
            // 
            // N_minuteOnEarth
            // 
            this.N_minuteOnEarth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.N_minuteOnEarth.Location = new System.Drawing.Point(391, 45);
            this.N_minuteOnEarth.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_minuteOnEarth.Name = "N_minuteOnEarth";
            this.N_minuteOnEarth.Size = new System.Drawing.Size(35, 20);
            this.N_minuteOnEarth.TabIndex = 24;
            // 
            // B_update
            // 
            this.B_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.B_update.Location = new System.Drawing.Point(227, 88);
            this.B_update.Name = "B_update";
            this.B_update.Size = new System.Drawing.Size(118, 35);
            this.B_update.TabIndex = 32;
            this.B_update.Text = "Enregistrer l\'heure du début de mission";
            this.B_update.UseVisualStyleBackColor = true;
            this.B_update.Click += new System.EventHandler(this.B_update_Click);
            // 
            // P_earth
            // 
            this.P_earth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_earth.Image = ((System.Drawing.Image)(resources.GetObject("P_earth.Image")));
            this.P_earth.Location = new System.Drawing.Point(199, 168);
            this.P_earth.Name = "P_earth";
            this.P_earth.Size = new System.Drawing.Size(133, 125);
            this.P_earth.TabIndex = 33;
            this.P_earth.TabStop = false;
            // 
            // P_mars
            // 
            this.P_mars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_mars.Image = ((System.Drawing.Image)(resources.GetObject("P_mars.Image")));
            this.P_mars.Location = new System.Drawing.Point(468, 168);
            this.P_mars.Name = "P_mars";
            this.P_mars.Size = new System.Drawing.Size(130, 132);
            this.P_mars.TabIndex = 34;
            this.P_mars.TabStop = false;
            // 
            // L_dayOnMars
            // 
            this.L_dayOnMars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dayOnMars.AutoSize = true;
            this.L_dayOnMars.Location = new System.Drawing.Point(468, 149);
            this.L_dayOnMars.Name = "L_dayOnMars";
            this.L_dayOnMars.Size = new System.Drawing.Size(63, 13);
            this.L_dayOnMars.TabIndex = 36;
            this.L_dayOnMars.Text = "Jour X, XhX";
            // 
            // L_dayOnEarth
            // 
            this.L_dayOnEarth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_dayOnEarth.AutoSize = true;
            this.L_dayOnEarth.Location = new System.Drawing.Point(222, 149);
            this.L_dayOnEarth.Name = "L_dayOnEarth";
            this.L_dayOnEarth.Size = new System.Drawing.Size(59, 13);
            this.L_dayOnEarth.TabIndex = 37;
            this.L_dayOnEarth.Text = "test de test";
            this.L_dayOnEarth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_missionDuration
            // 
            this.L_missionDuration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_missionDuration.AutoSize = true;
            this.L_missionDuration.Location = new System.Drawing.Point(225, 68);
            this.L_missionDuration.Name = "L_missionDuration";
            this.L_missionDuration.Size = new System.Drawing.Size(51, 13);
            this.L_missionDuration.TabIndex = 39;
            this.L_missionDuration.Text = "Mission : ";
            // 
            // L_listAstronauts
            // 
            this.L_listAstronauts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_listAstronauts.AutoSize = true;
            this.L_listAstronauts.Location = new System.Drawing.Point(492, 73);
            this.L_listAstronauts.Name = "L_listAstronauts";
            this.L_listAstronauts.Size = new System.Drawing.Size(72, 13);
            this.L_listAstronauts.TabIndex = 40;
            this.L_listAstronauts.Text = "Astronautes : ";
            // 
            // P_MissionEdition
            // 
            this.P_MissionEdition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_MissionEdition.Image = ((System.Drawing.Image)(resources.GetObject("P_MissionEdition.Image")));
            this.P_MissionEdition.Location = new System.Drawing.Point(201, 64);
            this.P_MissionEdition.Name = "P_MissionEdition";
            this.P_MissionEdition.Size = new System.Drawing.Size(26, 27);
            this.P_MissionEdition.TabIndex = 41;
            this.P_MissionEdition.TabStop = false;
            this.P_MissionEdition.Click += new System.EventHandler(this.P_MissionEdition_Click);
            // 
            // P_LinkingHours
            // 
            this.P_LinkingHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_LinkingHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_LinkingHours.Controls.Add(this.DTP_date);
            this.P_LinkingHours.Controls.Add(this.L_hourOnEarth);
            this.P_LinkingHours.Controls.Add(this.L_LinkingHours);
            this.P_LinkingHours.Controls.Add(this.N_hourOnEarth);
            this.P_LinkingHours.Controls.Add(this.N_minuteOnEarth);
            this.P_LinkingHours.Controls.Add(this.B_update);
            this.P_LinkingHours.Location = new System.Drawing.Point(114, 339);
            this.P_LinkingHours.Name = "P_LinkingHours";
            this.P_LinkingHours.Size = new System.Drawing.Size(526, 143);
            this.P_LinkingHours.TabIndex = 42;
            // 
            // L_LinkingHours
            // 
            this.L_LinkingHours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_LinkingHours.AutoSize = true;
            this.L_LinkingHours.Location = new System.Drawing.Point(96, 16);
            this.L_LinkingHours.Name = "L_LinkingHours";
            this.L_LinkingHours.Size = new System.Drawing.Size(357, 13);
            this.L_LinkingHours.TabIndex = 39;
            this.L_LinkingHours.Text = "Choix de la date du début de mission sur terre pour le jour marsien 1 à 0:00";
            // 
            // P_AstronutsEdition
            // 
            this.P_AstronutsEdition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_AstronutsEdition.Image = ((System.Drawing.Image)(resources.GetObject("P_AstronutsEdition.Image")));
            this.P_AstronutsEdition.Location = new System.Drawing.Point(468, 64);
            this.P_AstronutsEdition.Name = "P_AstronutsEdition";
            this.P_AstronutsEdition.Size = new System.Drawing.Size(26, 27);
            this.P_AstronutsEdition.TabIndex = 43;
            this.P_AstronutsEdition.TabStop = false;
            this.P_AstronutsEdition.Click += new System.EventHandler(this.P_AstronutsEdition_Click);
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(83, 45);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(200, 20);
            this.DTP_date.TabIndex = 44;
            // 
            // Fsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 675);
            this.Controls.Add(this.P_AstronutsEdition);
            this.Controls.Add(this.P_LinkingHours);
            this.Controls.Add(this.P_MissionEdition);
            this.Controls.Add(this.L_listAstronauts);
            this.Controls.Add(this.L_missionDuration);
            this.Controls.Add(this.L_dayOnEarth);
            this.Controls.Add(this.L_dayOnMars);
            this.Controls.Add(this.P_mars);
            this.Controls.Add(this.P_earth);
            this.Name = "Fsettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.Fsettings_Activated);
            this.Deactivate += new System.EventHandler(this.Fsettings_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.N_hourOnEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_minuteOnEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_mars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_MissionEdition)).EndInit();
            this.P_LinkingHours.ResumeLayout(false);
            this.P_LinkingHours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_AstronutsEdition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown N_hourOnEarth;
        private System.Windows.Forms.Label L_hourOnEarth;
        private System.Windows.Forms.NumericUpDown N_minuteOnEarth;
        private System.Windows.Forms.Button B_update;
        private System.Windows.Forms.PictureBox P_earth;
        private System.Windows.Forms.PictureBox P_mars;
        private System.Windows.Forms.Label L_dayOnMars;
        private System.Windows.Forms.Label L_dayOnEarth;
        private System.Windows.Forms.Label L_missionDuration;
        private System.Windows.Forms.Label L_listAstronauts;
        private System.Windows.Forms.PictureBox P_MissionEdition;
        private System.Windows.Forms.Panel P_LinkingHours;
        private System.Windows.Forms.Label L_LinkingHours;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.PictureBox P_AstronutsEdition;
        private System.Windows.Forms.DateTimePicker DTP_date;
    }
}