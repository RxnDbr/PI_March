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
    public partial class Fcontainer : Form
    {
        public Fcontainer()
        {
            InitializeComponent();
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            //Test for initializing or not the software
            /*if(not initialized)*/
            L_date.Text = "Jour ?, ?h?";
            Finitialization init = new Finitialization();
            init.MdiParent = this;
            init.StartPosition = FormStartPosition.CenterScreen;
            init.Show();
            

            Fcalendrier accueil = new Fcalendrier();
            accueil.MdiParent = init.MdiParent;
            accueil.StartPosition = FormStartPosition.CenterScreen;
            accueil.Size = new Size(Width - 4, Height - 4);
            accueil.Show();
        }
    }
}
