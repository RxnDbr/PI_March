using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mars
{

    public partial class Fcalender : Form
    {
        private Factivity f_activity;
        private int selectedDay; 

        public Fcalender(Fcontainer parent, Factivity activity)
        {
            InitializeComponent();
            //CASUAL
            MdiParent = parent;
            this.Dock = DockStyle.Fill;
            Visible = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //SPECIFIC
            for (int i = 0; i < 50; i++)
            {
                Test t = new Test(i);
                V_Activities.Items.Add(Convert.ToString(i));//, t.numTest);
            }
            f_activity = activity;
            //parent.Fcalendar_Set();
           
         
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

        private void Day1_Click(object sender, EventArgs e)
        {
            //Fcontainer parent = this.MdiParent as Fcontainer;
            //if(parent != null)
            f_activity.Activate();
            
            //activity.StartPosition = FormStartPosition.CenterScreen;
            //activity.Size = new Size(Parent.Width - 4, Parent.Height - 4);
            //activity.Show();
            //Close();
        }

        private void Fcalender_Deactivate(object sender, EventArgs e)
        {
            Fcontainer parent = this.MdiParent as Fcontainer;
            if (parent != null)
                parent.f_calendar_Deactivate(); 
        }

        private void Fcalender_Activated(object sender, EventArgs e)
        {
            Fcontainer parent = this.MdiParent as Fcontainer;
            if(parent != null)
                parent.f_calendar_Activate(); 
        }

        private void Fcalender_Shown(object sender, EventArgs e)
        {
            V_Activities.SelectedItems.Clear();
        }

        private void V_Activities_ItemActivate(object sender, EventArgs e)
        {
            //V_Activities.SelectedIndices.IndexOf(0);

            selectedDay = Convert.ToInt16(V_Activities.SelectedIndices[0].ToString());
            //f_activity = new Factivity((Fcontainer)this.MdiParent, selectedDay);
            f_activity.activity_show(selectedDay);
        }
    }
}
