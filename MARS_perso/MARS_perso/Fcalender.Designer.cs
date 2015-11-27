namespace Mars
{
    partial class Fcalender
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
            this.Day1 = new System.Windows.Forms.Button();
            this.V_Activities = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Day1
            // 
            this.Day1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Day1.Location = new System.Drawing.Point(417, 45);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(49, 23);
            this.Day1.TabIndex = 5;
            this.Day1.Text = "Day 1";
            this.Day1.UseVisualStyleBackColor = true;
            this.Day1.Click += new System.EventHandler(this.Day1_Click);
            // 
            // V_Activities
            // 
            this.V_Activities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.V_Activities.Location = new System.Drawing.Point(12, 74);
            this.V_Activities.MultiSelect = false;
            this.V_Activities.Name = "V_Activities";
            this.V_Activities.Size = new System.Drawing.Size(540, 291);
            this.V_Activities.TabIndex = 6;
            this.V_Activities.UseCompatibleStateImageBehavior = false;
            this.V_Activities.ItemActivate += new System.EventHandler(this.V_Activities_ItemActivate);
            // 
            // Fcalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(564, 377);
            this.ControlBox = false;
            this.Controls.Add(this.V_Activities);
            this.Controls.Add(this.Day1);
            this.MinimizeBox = false;
            this.Name = "Fcalender";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.Fcalender_Activated);
            this.Deactivate += new System.EventHandler(this.Fcalender_Deactivate);
            this.Shown += new System.EventHandler(this.Fcalender_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Day1;
        private System.Windows.Forms.ListView V_Activities;


    }
}

