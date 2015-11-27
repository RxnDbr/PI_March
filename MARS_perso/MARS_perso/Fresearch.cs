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
    public partial class Fresearch : Form
    {
        //private Activity selectedActivity;
        //private String selectedWords;
        //private int selectedDateFrom;
        //private int selectedDateTo;

        public Fresearch(Fcontainer parent)
        {
            InitializeComponent();
            //CASUAL
            MdiParent = parent;
            this.Dock = DockStyle.Fill;
            Visible = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //SPECIFIC
            L_error.Text = "";
            //N_dateFrom.Maximum = mission.Duration;
            //N_dateTo.Maximum = mission.Duration;
        }

        private void N_dateFrom_ValueChanged(object sender, EventArgs e)
        {
            //selectedDateFrom = Convert.ToInt32(N_dateFrom.Value);
            if (/*selectedDateTo < mission.Duration && */ /*selectedDateFrom > selectedDateTo)*/ N_dateFrom.Value > N_dateTo.Value)
            {
                
                L_error.Text = "* Aucune date ne correspond";
            }
            else
            {
                L_error.Text = "";
            }
        }

        private void N_dateTo_ValueChanged(object sender, EventArgs e)
        {
            //selectedDateTo = Convert.ToInt32(N_dateTo.Value);
            if (/*selectedDateFrom >= 1  && */ /*selectedDateFrom > selectedDateTo*/ N_dateFrom.Value > N_dateTo.Value)
                L_error.Text = "* Aucune date ne correspond";
            else            {
                L_error.Text = "";
            }
        }

        private void B_emptyFields_Click(object sender, EventArgs e)
        {
            N_dateFrom.Value = 1;
            //N_dateTo.Value = mission.Duration;
            T_searchByContent.Text = "";

            //selectedActivity = void;
            L_error.Text = "";
        }

        private void B_search_Click(object sender, EventArgs e)
        {
            if (L_error.Text == "")
            {
                //Lancement de la recherche
            }
        }
    }
}
