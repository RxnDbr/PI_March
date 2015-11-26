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
    public partial class FactivityEdition : Form
    {
        //private Activity selectedActivity;
        //private String selectedWords;
        //private int selectedDateFrom;
        //private int selectedDateTo;

        public FactivityEdition()
        {
            InitializeComponent();
            this.Focus();

            //private initialization
            //if(l'activité n'est pas en exterieur)
                //P_location.Show();
            //else
            P_location.Hide();
            B_save.Enabled = false;
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            //Save modifications

            //if(modifications saved)
            //{
                timerMessage.InitializeLifetimeService();
                timerMessage.Tick += new EventHandler(timerMessage_Tick);

                timerMessage.Start();

                timerMessage.Interval = (1000) * (3);
                L_saveNotification.ForeColor = Color.Green;
                L_saveNotification.Text = "Enregistrement avec succès";
            //}
            //else
            //{
                //L_saveNotification.ForeColor = Color.Red;
                //L_saveNotification.Text = "Une erreur est survenue";
            //}
        }
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            L_saveNotification.Text = "";
            timerMessage.Stop();
        }

        private void InputChanges(object sender, EventArgs e)
        {
            B_save.Enabled = true;
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            //if
            if (B_save.Enabled)
            { 
                //Opening of a new Form to confirm the close of the windows without saving 
            }
            Close();
        }

        private void B_empty_Click(object sender, EventArgs e)
        {
            //Location values
            T_locationName.Text = ""; //get activity description
            N_positionHorizontal.Value = 0; //get activity description
            N_positionVertical.Value = 0; //get activity description

            //Description
            T_description.Text = ""; //get activity description
            
            //Activity
            list_activity.ClearSelected(); //get activity description
            
            //Astronuts
            checkedList_astronauts.ClearSelected(); //get activity description
            B_save.Enabled = false;
        }

        private void B_selectOnMap_Click(object sender, EventArgs e)
        {
            //Afficher la carte et récupérer les données
        }
    }
}
