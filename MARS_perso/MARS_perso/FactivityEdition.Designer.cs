namespace MARS_perso
{
    partial class FactivityEdition
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
            this.B_cancel = new System.Windows.Forms.Button();
            this.B_save = new System.Windows.Forms.Button();
            this.L_Activity = new System.Windows.Forms.Label();
            this.list_activity = new System.Windows.Forms.ListBox();
            this.L_day = new System.Windows.Forms.Label();
            this.L_dateFrom = new System.Windows.Forms.Label();
            this.N_dateHour = new System.Windows.Forms.NumericUpDown();
            this.L_hourFrom = new System.Windows.Forms.Label();
            this.N_dateMinute = new System.Windows.Forms.NumericUpDown();
            this.L_dateTo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.N_dateToMinute = new System.Windows.Forms.NumericUpDown();
            this.L_hourTo = new System.Windows.Forms.Label();
            this.L_astronuts = new System.Windows.Forms.Label();
            this.L_description = new System.Windows.Forms.Label();
            this.T_description = new System.Windows.Forms.TextBox();
            this.P_location = new System.Windows.Forms.Panel();
            this.B_selectOnMap = new System.Windows.Forms.Button();
            this.N_positionVertical = new System.Windows.Forms.NumericUpDown();
            this.L_positionVertical = new System.Windows.Forms.Label();
            this.L_positionHorizontal = new System.Windows.Forms.Label();
            this.N_positionHorizontal = new System.Windows.Forms.NumericUpDown();
            this.T_locationName = new System.Windows.Forms.TextBox();
            this.L_position = new System.Windows.Forms.Label();
            this.L_locationName = new System.Windows.Forms.Label();
            this.L_location = new System.Windows.Forms.Label();
            this.B_empty = new System.Windows.Forms.Button();
            this.checkedList_astronauts = new System.Windows.Forms.CheckedListBox();
            this.L_dayIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.L_saveNotification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).BeginInit();
            this.P_location.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_positionVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_positionHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // B_cancel
            // 
            this.B_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_cancel.Location = new System.Drawing.Point(360, 337);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(75, 23);
            this.B_cancel.TabIndex = 0;
            this.B_cancel.Text = "Fermer";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // B_save
            // 
            this.B_save.Location = new System.Drawing.Point(178, 337);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(161, 23);
            this.B_save.TabIndex = 1;
            this.B_save.Text = "Enregistrer les modification";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // L_Activity
            // 
            this.L_Activity.AutoSize = true;
            this.L_Activity.Location = new System.Drawing.Point(69, 74);
            this.L_Activity.Name = "L_Activity";
            this.L_Activity.Size = new System.Drawing.Size(42, 13);
            this.L_Activity.TabIndex = 6;
            this.L_Activity.Text = "Activité";
            // 
            // list_activity
            // 
            this.list_activity.FormattingEnabled = true;
            this.list_activity.Location = new System.Drawing.Point(72, 90);
            this.list_activity.Name = "list_activity";
            this.list_activity.Size = new System.Drawing.Size(120, 17);
            this.list_activity.TabIndex = 7;
            this.list_activity.SelectedIndexChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_day
            // 
            this.L_day.AutoSize = true;
            this.L_day.Location = new System.Drawing.Point(73, 9);
            this.L_day.Name = "L_day";
            this.L_day.Size = new System.Drawing.Size(37, 13);
            this.L_day.TabIndex = 11;
            this.L_day.Text = "Jour X";
            // 
            // L_dateFrom
            // 
            this.L_dateFrom.AutoSize = true;
            this.L_dateFrom.Location = new System.Drawing.Point(175, 9);
            this.L_dateFrom.Name = "L_dateFrom";
            this.L_dateFrom.Size = new System.Drawing.Size(36, 13);
            this.L_dateFrom.TabIndex = 19;
            this.L_dateFrom.Text = "Début";
            // 
            // N_dateHour
            // 
            this.N_dateHour.Location = new System.Drawing.Point(217, 7);
            this.N_dateHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.N_dateHour.Name = "N_dateHour";
            this.N_dateHour.Size = new System.Drawing.Size(35, 20);
            this.N_dateHour.TabIndex = 20;
            this.N_dateHour.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_hourFrom
            // 
            this.L_hourFrom.AutoSize = true;
            this.L_hourFrom.Location = new System.Drawing.Point(258, 9);
            this.L_hourFrom.Name = "L_hourFrom";
            this.L_hourFrom.Size = new System.Drawing.Size(15, 13);
            this.L_hourFrom.TabIndex = 22;
            this.L_hourFrom.Text = "H";
            // 
            // N_dateMinute
            // 
            this.N_dateMinute.Location = new System.Drawing.Point(270, 7);
            this.N_dateMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateMinute.Name = "N_dateMinute";
            this.N_dateMinute.Size = new System.Drawing.Size(35, 20);
            this.N_dateMinute.TabIndex = 24;
            this.N_dateMinute.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_dateTo
            // 
            this.L_dateTo.AutoSize = true;
            this.L_dateTo.Location = new System.Drawing.Point(318, 9);
            this.L_dateTo.Name = "L_dateTo";
            this.L_dateTo.Size = new System.Drawing.Size(27, 13);
            this.L_dateTo.TabIndex = 25;
            this.L_dateTo.Text = "-- fin";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(348, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // N_dateToMinute
            // 
            this.N_dateToMinute.Location = new System.Drawing.Point(401, 7);
            this.N_dateToMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.N_dateToMinute.Name = "N_dateToMinute";
            this.N_dateToMinute.Size = new System.Drawing.Size(34, 20);
            this.N_dateToMinute.TabIndex = 27;
            this.N_dateToMinute.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_hourTo
            // 
            this.L_hourTo.AutoSize = true;
            this.L_hourTo.Location = new System.Drawing.Point(380, 9);
            this.L_hourTo.Name = "L_hourTo";
            this.L_hourTo.Size = new System.Drawing.Size(15, 13);
            this.L_hourTo.TabIndex = 28;
            this.L_hourTo.Text = "H";
            // 
            // L_astronuts
            // 
            this.L_astronuts.AutoSize = true;
            this.L_astronuts.Location = new System.Drawing.Point(69, 119);
            this.L_astronuts.Name = "L_astronuts";
            this.L_astronuts.Size = new System.Drawing.Size(63, 13);
            this.L_astronuts.TabIndex = 29;
            this.L_astronuts.Text = "Astronautes";
            // 
            // L_description
            // 
            this.L_description.AutoSize = true;
            this.L_description.Location = new System.Drawing.Point(69, 250);
            this.L_description.Name = "L_description";
            this.L_description.Size = new System.Drawing.Size(60, 13);
            this.L_description.TabIndex = 31;
            this.L_description.Text = "Description";
            // 
            // T_description
            // 
            this.T_description.Location = new System.Drawing.Point(72, 266);
            this.T_description.Multiline = true;
            this.T_description.Name = "T_description";
            this.T_description.Size = new System.Drawing.Size(363, 49);
            this.T_description.TabIndex = 32;
            this.T_description.TextChanged += new System.EventHandler(this.InputChanges);
            // 
            // P_location
            // 
            this.P_location.Controls.Add(this.B_selectOnMap);
            this.P_location.Controls.Add(this.N_positionVertical);
            this.P_location.Controls.Add(this.L_positionVertical);
            this.P_location.Controls.Add(this.L_positionHorizontal);
            this.P_location.Controls.Add(this.N_positionHorizontal);
            this.P_location.Controls.Add(this.T_locationName);
            this.P_location.Controls.Add(this.L_position);
            this.P_location.Controls.Add(this.L_locationName);
            this.P_location.Controls.Add(this.L_location);
            this.P_location.Location = new System.Drawing.Point(241, 73);
            this.P_location.Name = "P_location";
            this.P_location.Size = new System.Drawing.Size(194, 187);
            this.P_location.TabIndex = 33;
            // 
            // B_selectOnMap
            // 
            this.B_selectOnMap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_selectOnMap.Location = new System.Drawing.Point(39, 133);
            this.B_selectOnMap.Name = "B_selectOnMap";
            this.B_selectOnMap.Size = new System.Drawing.Size(120, 37);
            this.B_selectOnMap.TabIndex = 38;
            this.B_selectOnMap.Text = "Selectionner le lieu sur la carte";
            this.B_selectOnMap.UseVisualStyleBackColor = true;
            this.B_selectOnMap.Click += new System.EventHandler(this.B_selectOnMap_Click);
            // 
            // N_positionVertical
            // 
            this.N_positionVertical.Location = new System.Drawing.Point(132, 103);
            this.N_positionVertical.Name = "N_positionVertical";
            this.N_positionVertical.Size = new System.Drawing.Size(42, 20);
            this.N_positionVertical.TabIndex = 40;
            this.N_positionVertical.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_positionVertical
            // 
            this.L_positionVertical.AutoSize = true;
            this.L_positionVertical.Location = new System.Drawing.Point(57, 105);
            this.L_positionVertical.Name = "L_positionVertical";
            this.L_positionVertical.Size = new System.Drawing.Size(58, 13);
            this.L_positionVertical.TabIndex = 39;
            this.L_positionVertical.Text = "vertical (m)";
            // 
            // L_positionHorizontal
            // 
            this.L_positionHorizontal.AutoSize = true;
            this.L_positionHorizontal.Location = new System.Drawing.Point(57, 82);
            this.L_positionHorizontal.Name = "L_positionHorizontal";
            this.L_positionHorizontal.Size = new System.Drawing.Size(69, 13);
            this.L_positionHorizontal.TabIndex = 38;
            this.L_positionHorizontal.Text = "horizontal (m)";
            // 
            // N_positionHorizontal
            // 
            this.N_positionHorizontal.Location = new System.Drawing.Point(132, 80);
            this.N_positionHorizontal.Name = "N_positionHorizontal";
            this.N_positionHorizontal.Size = new System.Drawing.Size(42, 20);
            this.N_positionHorizontal.TabIndex = 37;
            this.N_positionHorizontal.ValueChanged += new System.EventHandler(this.InputChanges);
            // 
            // T_locationName
            // 
            this.T_locationName.Location = new System.Drawing.Point(70, 31);
            this.T_locationName.Name = "T_locationName";
            this.T_locationName.Size = new System.Drawing.Size(88, 20);
            this.T_locationName.TabIndex = 36;
            this.T_locationName.TextChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_position
            // 
            this.L_position.AutoSize = true;
            this.L_position.Location = new System.Drawing.Point(36, 61);
            this.L_position.Name = "L_position";
            this.L_position.Size = new System.Drawing.Size(44, 13);
            this.L_position.TabIndex = 35;
            this.L_position.Text = "Position";
            // 
            // L_locationName
            // 
            this.L_locationName.AutoSize = true;
            this.L_locationName.Location = new System.Drawing.Point(35, 34);
            this.L_locationName.Name = "L_locationName";
            this.L_locationName.Size = new System.Drawing.Size(29, 13);
            this.L_locationName.TabIndex = 34;
            this.L_locationName.Text = "Nom";
            // 
            // L_location
            // 
            this.L_location.AutoSize = true;
            this.L_location.Location = new System.Drawing.Point(5, 15);
            this.L_location.Name = "L_location";
            this.L_location.Size = new System.Drawing.Size(27, 13);
            this.L_location.TabIndex = 34;
            this.L_location.Text = "Lieu";
            // 
            // B_empty
            // 
            this.B_empty.Location = new System.Drawing.Point(28, 337);
            this.B_empty.Name = "B_empty";
            this.B_empty.Size = new System.Drawing.Size(128, 23);
            this.B_empty.TabIndex = 34;
            this.B_empty.Text = "Réinitialiser les champs";
            this.B_empty.UseVisualStyleBackColor = true;
            this.B_empty.Click += new System.EventHandler(this.B_empty_Click);
            // 
            // checkedList_astronauts
            // 
            this.checkedList_astronauts.FormattingEnabled = true;
            this.checkedList_astronauts.Location = new System.Drawing.Point(72, 135);
            this.checkedList_astronauts.Name = "checkedList_astronauts";
            this.checkedList_astronauts.Size = new System.Drawing.Size(139, 94);
            this.checkedList_astronauts.TabIndex = 35;
            this.checkedList_astronauts.SelectedIndexChanged += new System.EventHandler(this.InputChanges);
            // 
            // L_dayIn
            // 
            this.L_dayIn.AutoSize = true;
            this.L_dayIn.Location = new System.Drawing.Point(73, 31);
            this.L_dayIn.Name = "L_dayIn";
            this.L_dayIn.Size = new System.Drawing.Size(65, 13);
            this.L_dayIn.TabIndex = 36;
            this.L_dayIn.Text = "dans X jours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Durée : XHX";
            // 
            // L_saveNotification
            // 
            this.L_saveNotification.AutoSize = true;
            this.L_saveNotification.Location = new System.Drawing.Point(75, 44);
            this.L_saveNotification.Name = "L_saveNotification";
            this.L_saveNotification.Size = new System.Drawing.Size(0, 13);
            this.L_saveNotification.TabIndex = 38;
            // 
            // FactivityEdition
            // 
            this.AcceptButton = this.B_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_cancel;
            this.ClientSize = new System.Drawing.Size(497, 381);
            this.Controls.Add(this.L_saveNotification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_dayIn);
            this.Controls.Add(this.checkedList_astronauts);
            this.Controls.Add(this.B_empty);
            this.Controls.Add(this.P_location);
            this.Controls.Add(this.T_description);
            this.Controls.Add(this.L_description);
            this.Controls.Add(this.L_astronuts);
            this.Controls.Add(this.L_hourTo);
            this.Controls.Add(this.N_dateToMinute);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.L_dateTo);
            this.Controls.Add(this.N_dateMinute);
            this.Controls.Add(this.L_hourFrom);
            this.Controls.Add(this.N_dateHour);
            this.Controls.Add(this.L_dateFrom);
            this.Controls.Add(this.L_day);
            this.Controls.Add(this.list_activity);
            this.Controls.Add(this.L_Activity);
            this.Controls.Add(this.B_save);
            this.Controls.Add(this.B_cancel);
            this.Name = "FactivityEdition";
            this.Text = "Edition des activités";
            ((System.ComponentModel.ISupportInitialize)(this.N_dateHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_dateToMinute)).EndInit();
            this.P_location.ResumeLayout(false);
            this.P_location.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_positionVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_positionHorizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_cancel;
        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.Label L_Activity;
        private System.Windows.Forms.ListBox list_activity;
        private System.Windows.Forms.Label L_day;
        private System.Windows.Forms.Label L_dateFrom;
        private System.Windows.Forms.NumericUpDown N_dateHour;
        private System.Windows.Forms.Label L_hourFrom;
        private System.Windows.Forms.NumericUpDown N_dateMinute;
        private System.Windows.Forms.Label L_dateTo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown N_dateToMinute;
        private System.Windows.Forms.Label L_hourTo;
        private System.Windows.Forms.Label L_astronuts;
        private System.Windows.Forms.Label L_description;
        private System.Windows.Forms.TextBox T_description;
        private System.Windows.Forms.Panel P_location;
        private System.Windows.Forms.Label L_location;
        private System.Windows.Forms.TextBox T_locationName;
        private System.Windows.Forms.Label L_position;
        private System.Windows.Forms.Label L_locationName;
        private System.Windows.Forms.Label L_positionHorizontal;
        private System.Windows.Forms.NumericUpDown N_positionHorizontal;
        private System.Windows.Forms.Label L_positionVertical;
        private System.Windows.Forms.NumericUpDown N_positionVertical;
        private System.Windows.Forms.Button B_empty;
        private System.Windows.Forms.CheckedListBox checkedList_astronauts;
        private System.Windows.Forms.Label L_dayIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_selectOnMap;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.Label L_saveNotification;

    }
}