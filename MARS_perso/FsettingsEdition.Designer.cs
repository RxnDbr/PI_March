namespace MARS_perso
{
    partial class FsettingsEdition
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
            this.B_save = new System.Windows.Forms.Button();
            this.B_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_save
            // 
            this.B_save.Location = new System.Drawing.Point(108, 196);
            this.B_save.Name = "B_save";
            this.B_save.Size = new System.Drawing.Size(75, 23);
            this.B_save.TabIndex = 0;
            this.B_save.Text = "Enregistrer";
            this.B_save.UseVisualStyleBackColor = true;
            this.B_save.Click += new System.EventHandler(this.B_save_Click);
            // 
            // B_cancel
            // 
            this.B_cancel.Location = new System.Drawing.Point(233, 196);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(75, 23);
            this.B_cancel.TabIndex = 1;
            this.B_cancel.Text = "Annuler";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.B_cancel_Click);
            // 
            // FsettingsEdition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 263);
            this.Controls.Add(this.B_cancel);
            this.Controls.Add(this.B_save);
            this.Name = "FsettingsEdition";
            this.Text = "Edition des paramètres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_save;
        private System.Windows.Forms.Button B_cancel;
    }
}