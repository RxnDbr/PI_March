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
    public partial class Fcontainer : Form
    {
        private Fsettings f_settings;
        private Fresearch f_research;
        private Fexploration f_exploration;
        private Fcalender f_calendar;
        private Factivity f_activity;

        private DateTime dateOnMars;

        private Timer t_timer = new Timer();
        //public Mission mission;

        public Fcontainer()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            f_research = new Fresearch(this);
            f_exploration = new Fexploration(this);
            f_activity = new Factivity(this);
            f_calendar = new Fcalender(this, f_activity);
            f_settings = new Fsettings(this);
            
            
            //calendar.Size = new Size(Width - 4, Height - 4);
            
            //Test if the mission isn't initialized
            /*if(not initialized)*/
            //L_date.Text = "Jour ?, ?h?";
           
            //f_settings.BringToFront();
            f_settings.Activate();
        }


        //
        //About TIMER
        //
        private void FContainer_Load(object sender, EventArgs e)
        {
            t_timer.Interval = 1000;
            t_timer.Tick += new EventHandler(t_timer_Tick);
            t_timer.Start();
        }

        void t_timer_Tick(object sender, EventArgs e)
        {
            this.L_date.Text = "Jour " + DateTime.Now.ToString();
        }

        //
        //About RESEARCH
        //
        private void P_research_Click(object sender, EventArgs e)
        {
            f_research.Activate();
        }

        //
        //About EXPLORATION
        //
        private void P_astronaute_Click(object sender, EventArgs e)
        {
            //P_calendar.BringToFront();
            f_exploration.Activate();
            //f_exploration.Focus();
        }

        //
        //About SETTINGS
        //
        private void P_settings_Click(object sender, EventArgs e)
        {
            f_settings.Activate();
        }
        public void f_settings_Activate()
        {
            P_calendar.BringToFront();

            //Hidden button
            P_settings.Hide();
            P_research.Hide();
            P_astronaute.Hide();
            L_date.Hide();
        }
        public void f_settings_Deactivate()
        {
            P_calendar.BringToFront();

            //Show button
            P_settings.Show();
            P_research.Show();
            P_astronaute.Show();
            L_date.Show();
        }
        //
        //About CALENDAR
        //
        private void P_calendar_Click(object sender, EventArgs e)
        {
            //Visible button
            P_settings.Show();
            P_research.Show();
            P_astronaute.Show();
            L_date.Show();
            P_settings.BringToFront();

            f_calendar.Activate();
            //f_calendar.Focus();
        }
        public void f_calendar_Activate()
        {
            P_settings.Show();
            P_calendar.Hide();
        }
        public void f_calendar_Deactivate()
        {
                P_settings.Hide();
                P_calendar.Show();
        }
        //
        //About CONTAINER
        //
        private void Fcontainer_AutoSizeChanged(object sender, EventArgs e)
        {
            f_settings.Dock = DockStyle.Fill;
            f_research.Dock = DockStyle.Fill;
            f_exploration.Dock = DockStyle.Fill;
            f_calendar.Dock = DockStyle.Fill;
            //f_activity.Dock = DockStyle.Fill;
        }

        private void L_date_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(dateOnMars.Day);
            //f_activity = new Factivity(this, number);
            f_activity.activity_show(number);
        }
    }
}
