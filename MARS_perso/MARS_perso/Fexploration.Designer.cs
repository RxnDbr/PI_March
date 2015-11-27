namespace MARS_perso
{
    partial class Fexploration
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
            System.Windows.Forms.ColumnHeader V_column;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fexploration));
            this.P_plan = new System.Windows.Forms.PictureBox();
            this.L_coordonee = new System.Windows.Forms.Label();
            this.L_click = new System.Windows.Forms.Label();
            this.V_Exploration = new System.Windows.Forms.ListView();
            V_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.P_plan)).BeginInit();
            this.SuspendLayout();
            // 
            // V_column
            // 
            V_column.Text = "Résultats";
            V_column.Width = 121;
            // 
            // P_plan
            // 
            this.P_plan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_plan.Image = ((System.Drawing.Image)(resources.GetObject("P_plan.Image")));
            this.P_plan.Location = new System.Drawing.Point(12, 84);
            this.P_plan.Name = "P_plan";
            this.P_plan.Size = new System.Drawing.Size(1096, 1016);
            this.P_plan.TabIndex = 3;
            this.P_plan.TabStop = false;
            this.P_plan.Click += new System.EventHandler(this.P_plan_Click);
            // 
            // L_coordonee
            // 
            this.L_coordonee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_coordonee.AutoSize = true;
            this.L_coordonee.Location = new System.Drawing.Point(314, 56);
            this.L_coordonee.Name = "L_coordonee";
            this.L_coordonee.Size = new System.Drawing.Size(64, 13);
            this.L_coordonee.TabIndex = 4;
            this.L_coordonee.Text = "Coordonées";
            // 
            // L_click
            // 
            this.L_click.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_click.AutoSize = true;
            this.L_click.Location = new System.Drawing.Point(317, 84);
            this.L_click.Name = "L_click";
            this.L_click.Size = new System.Drawing.Size(44, 13);
            this.L_click.TabIndex = 5;
            this.L_click.Text = "on click";
            // 
            // V_Exploration
            // 
            this.V_Exploration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.V_Exploration.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            V_column});
            this.V_Exploration.Location = new System.Drawing.Point(1085, 84);
            this.V_Exploration.Name = "V_Exploration";
            this.V_Exploration.Size = new System.Drawing.Size(144, 389);
            this.V_Exploration.TabIndex = 6;
            this.V_Exploration.UseCompatibleStateImageBehavior = false;
            this.V_Exploration.View = System.Windows.Forms.View.Details;
            // 
            // Fexploration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1251, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.V_Exploration);
            this.Controls.Add(this.L_click);
            this.Controls.Add(this.L_coordonee);
            this.Controls.Add(this.P_plan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fexploration";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.P_plan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_plan;
        private System.Windows.Forms.Label L_coordonee;
        private System.Windows.Forms.Label L_click;
        private System.Windows.Forms.ListView V_Exploration;
    }
}