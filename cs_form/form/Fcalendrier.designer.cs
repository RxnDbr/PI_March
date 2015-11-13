namespace MARS_perso
{
    partial class Fcalendrier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcalendrier));
            this.P_astronaute = new System.Windows.Forms.PictureBox();
            this.Day1 = new System.Windows.Forms.Button();
            this.P_research = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P_astronaute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_research)).BeginInit();
            this.SuspendLayout();
            // 
            // P_astronaute
            // 
            this.P_astronaute.AccessibleName = "P_astronaute";
            this.P_astronaute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_astronaute.Image = ((System.Drawing.Image)(resources.GetObject("P_astronaute.Image")));
            this.P_astronaute.Location = new System.Drawing.Point(377, 12);
            this.P_astronaute.Name = "P_astronaute";
            this.P_astronaute.Size = new System.Drawing.Size(31, 34);
            this.P_astronaute.TabIndex = 4;
            this.P_astronaute.TabStop = false;
            this.P_astronaute.Click += new System.EventHandler(this.P_astronaute_Click);
            // 
            // Day1
            // 
            this.Day1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Day1.Location = new System.Drawing.Point(174, 69);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(49, 23);
            this.Day1.TabIndex = 5;
            this.Day1.Text = "Day 1";
            this.Day1.UseVisualStyleBackColor = true;
            this.Day1.Click += new System.EventHandler(this.Day1_Click);
            // 
            // P_research
            // 
            this.P_research.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P_research.Image = ((System.Drawing.Image)(resources.GetObject("P_research.Image")));
            this.P_research.Location = new System.Drawing.Point(340, 13);
            this.P_research.Name = "P_research";
            this.P_research.Size = new System.Drawing.Size(31, 33);
            this.P_research.TabIndex = 6;
            this.P_research.TabStop = false;
            this.P_research.Click += new System.EventHandler(this.P_research_Click);
            // 
            // Fcalendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(420, 188);
            this.ControlBox = false;
            this.Controls.Add(this.P_research);
            this.Controls.Add(this.Day1);
            this.Controls.Add(this.P_astronaute);
            this.MinimizeBox = false;
            this.Name = "Fcalendrier";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.P_astronaute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_research)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox P_astronaute;
        private System.Windows.Forms.Button Day1;
        private System.Windows.Forms.PictureBox P_research;


    }
}

