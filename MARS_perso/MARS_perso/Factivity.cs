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
    public partial class Factivity : Form
    {
        private int selectedDay;

        public Factivity(Fcontainer parent)
        {
            InitializeComponent();
            //CASUAL
            MdiParent = parent;
            this.Dock = DockStyle.Fill;
            Visible = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //SPECIFIC
        }

        public void activity_show(int refday)
        {
            selectedDay = refday;
            L_day.Text = "Jour " + selectedDay;
            this.Activate();
        }

        private void P_addActivity_Click(object sender, EventArgs e)
        {
            FactivityEdition f = new FactivityEdition();
            f.ShowDialog();
        }
    }
}
