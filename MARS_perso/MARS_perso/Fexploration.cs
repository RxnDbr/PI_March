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
    public partial class Fexploration : Form
    {
        private Point mousePosition;

        public Fexploration(Fcontainer parent)
        {
            InitializeComponent();
            //CASUAL
            MdiParent = parent;
            this.Dock = DockStyle.Fill;
            Visible = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //SPECIFIC
            L_coordonee.Text = P_plan.Location.ToString();

            //V_Exploration.Scrollable = true;
            //V_Exploration.View = View.Details;
            //ColumnHeader header = new ColumnHeader();
            //header.Text = "";
            //header.Name = "col1";
            //V_column.
            //V_Exploration.Columns.ContainsKey();
            
            for (int i = 0; i < 50; i++)
            {
                //Test t = new Test(i);
                V_Exploration.Items.Add(Convert.ToString(i));
            }

        }

        private void P_plan_Click(object sender, EventArgs e)
        {
            mousePosition = P_plan.PointToClient(Cursor.Position);
            L_click.Text = "X=" + mousePosition.X + "," + "Y= " + mousePosition.Y;
        }

        /*
        private void P_plan_MouseMove(object sender, MouseEventArgs e)
        {
            //mousePosition = PictureBox1.PointToClient(Cursor.Position);
            //TextBox2.Text = ("X=" & LocalMousePosition.X & "," & "Y= " & LocalMousePosition.Y)
        }*/
    }
}
