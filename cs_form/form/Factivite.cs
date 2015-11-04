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
    public partial class Factivite : Form
    {
        public Factivite()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void P_calendar_Click(object sender, EventArgs e)
        {
            Fcalendrier RetourCalendrier = new Fcalendrier();
            RetourCalendrier.MdiParent = this.MdiParent;
            RetourCalendrier.StartPosition = FormStartPosition.CenterScreen;
            RetourCalendrier.Size = new Size(Parent.Width - 4, Parent.Height - 4);
            RetourCalendrier.Show();
            Close();
        }

        private void P_addActivity_Click(object sender, EventArgs e)
        {
            FActivityEdition f = new FActivityEdition();
            f.ShowDialog();
        }
    }
}
