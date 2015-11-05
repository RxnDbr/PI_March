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
    public partial class FActivityEdition : Form
    {
        public FActivityEdition()
        {
            InitializeComponent();
            this.Focus();
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            //Save modifications
            Close();
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
