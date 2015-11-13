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
    public partial class Finitialization : Form
    {
        public Finitialization()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            N_dayOnEarth.Value = DateTime.Today.Day;
            N_hourOnEarth.Value = DateTime.Today.Hour;
            N_minuteOnEarth.Value = DateTime.Today.Minute;
            
        }

        private void B_validate_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
