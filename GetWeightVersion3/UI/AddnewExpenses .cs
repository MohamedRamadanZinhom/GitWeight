using GetWeightVersion3.Classes;
using GetWeightVersion3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWeightVersion3.UI
{
    public partial class AddnewExpenses : Form
    {
        public AddnewExpenses()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Expensess expensses = new Expensess();
            expensses.Date = DateTime.Now.ToShortDateString();
            expensses.DESC = txtdesc.Text;
            expensses.Cost = txtcost.Text;
            expensses.Employee_Name = Properties.Settings.Default.Logedin_Name;

            new DataAccess().AddExpenses(expensses);
           
        }


        bool mousedowen = false;
        Point primarypoint;
        private void AddnewExpenses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void AddnewExpenses_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void AddnewExpenses_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
    }
}
