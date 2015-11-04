using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARS_perso
{
    public partial class Fcalendrier : Form
    {
        public Fcalendrier()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         
            /*if(Parent.SizeChanged == true)
            {
                this.Size = new Size(Parent.Width-4, Parent.Height-4);
            }*/
            //Size = new System.Drawing.Size(Parent.Width - 4, Parent.Height - 4);
            //Size = new Size();
            //this.Size.Width = this.MdiParent.Size.Width;
                // (MdiParent.Size);
                // = this.MdiParent.GetContainerControl();

        }
        private void P_astronaute_Click(object sender, EventArgs e)
        {
            Fexploration rechercheExp = new Fexploration();
            rechercheExp.MdiParent = this.MdiParent;
            rechercheExp.StartPosition = FormStartPosition.CenterScreen;
            //rechercheExp.Size = MdiParent.Size;
            rechercheExp.Size = new Size(Parent.Width-4, Parent.Height-4);
            rechercheExp.Show();
            Close();
        }

        private void Day1_Click(object sender, EventArgs e)
        {
            Factivite activity = new Factivite();
            activity.MdiParent = this.MdiParent;
            activity.StartPosition = FormStartPosition.CenterScreen;
            activity.Size = new Size(Parent.Width - 4, Parent.Height - 4);
            activity.Show();
            Close();
        }

        private void P_research_Click(object sender, EventArgs e)
        {
            Fresearch research = new Fresearch();
            research.MdiParent = this.MdiParent;
            research.StartPosition = FormStartPosition.CenterScreen;
            research.Size = new Size(Parent.Width - 4, Parent.Height - 4);
            research.Show();
            Close();
        }
    }
}
