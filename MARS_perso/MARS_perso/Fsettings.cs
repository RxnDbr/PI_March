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
    public partial class Fsettings : Form
    {
        private DateTime date_mars; //to convert into Mars date
        private DateTime date_Earth;
        private DateTime date_EarthStarting;


        public Fsettings(Fcontainer parent)
        {
            InitializeComponent();
            //CASUAL
            MdiParent = parent;
            this.Dock = DockStyle.Fill;
            Visible = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //SPECIFIC
            //Timer display IRT
            date_Earth = DateTime.UtcNow;
            L_dayOnEarth.Text = date_Earth.ToString();

            //refreshing date displays every seconds.
            timerTime.InitializeLifetimeService();
            timerTime.Tick += (sender, eventArgs) => 
            {
                date_Earth.AddMinutes(1);
                L_dayOnEarth.Text = date_Earth.ToString();
                if (date_mars != null && date_EarthStarting != null && date_Earth.CompareTo(date_EarthStarting) > 0 )
                {
                    date_mars.AddMinutes(1);
                    L_dayOnMars.Text = date_mars.ToString();
                }
            }; 
            timerTime.Interval = (1000) * (60); 

            //Fixed when settings on the screen.
            N_hourOnEarth.Value = date_EarthStarting.Hour;
            N_minuteOnEarth.Value = date_EarthStarting.Minute;
            
            //Loading date_mars and date_Earth from XML
            show_timeOnMars();
        }

        private void show_timeOnMars()
        {
            L_dayOnMars.ForeColor = Color.Red;
            
            if (date_mars != null && date_EarthStarting != new DateTime())
            {
                if (date_Earth < date_EarthStarting)
                {
                    double difD = Math.Round(date_EarthStarting.Subtract(date_Earth).TotalDays, 2);
                    double difH =  Math.Round(date_EarthStarting.Subtract(date_Earth).TotalHours, 2);
                    double difM = Math.Round(date_EarthStarting.Subtract(date_Earth).TotalMinutes, 2);
                    if (difD < 0)
                    {
                        if (difH < 0)
                        {
                            L_dayOnMars.Text = "Commencement de la mission dans " + difM + " minutes";
                        }
                        else
                        {
                            L_dayOnMars.Text = "Commencement de la mission dans " + difH + " heures";
                        }
                    }
                    else
                    {
                        L_dayOnMars.Text = "Commencement de la mission dans " + difD + " jours";
                    }
                }
                else //if (date_Earth > date_EarthStarting)
                {
                    //First : confirmation
                    L_dayOnMars.Text = "(Calcul de la date actuelle)" + date_EarthStarting;
                }
            }
            else //if date_mars is not set OR date_Earth is not set)
            {
                L_dayOnMars.Text = "Aucun jour n'a encore été choisi pour commencer la mission.\n Choississez un horaire de Greenwich correspondant au début de la mission.";
            }
        }

        //
        //(DE)ACTIVATE SETTINGS
        //
        private void Fsettings_Activated(object sender, EventArgs e)
        {
            Fcontainer parent = this.MdiParent as Fcontainer;
            if(parent != null)
                parent.f_settings_Activate(); 
        }
        private void Fsettings_Deactivate(object sender, EventArgs e)
        {
            Fcontainer parent = this.MdiParent as Fcontainer;
            if(parent != null)
                parent.f_settings_Deactivate(); 
        }

        private void B_update_Click(object sender, EventArgs e)
        {
            //DateTime date = MC_date.SelectionStart;
            date_EarthStarting = DTP_date.Value; //MC_date.SelectionStart;
            show_timeOnMars();
            //date_EarthStarting.Hour = (decimal)N_hourOnEarth.Value;
            //date_EarthStarting.time
            //date_EarthStarting.Minute = (decimal)N_minuteOnEarth.Value;
            //DateTimePicker picker = new DateTimePicker();
            //date_EarthStarting.Hour = N_hourOnEarth.Value; //            N_minuteOnEarth.Value = DateTime.Now.Minute;
        }
        
        private void P_MissionEdition_Click(object sender, EventArgs e)
        {
            FsettingsEdition f = new FsettingsEdition();
            f.ShowDialog();
        }

        private void P_AstronutsEdition_Click(object sender, EventArgs e)
        {
            FsettingsEdition f = new FsettingsEdition();
            f.ShowDialog();
        }

    }
}
