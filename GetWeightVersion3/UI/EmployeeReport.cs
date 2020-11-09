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
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            txtemp.Text = " Welcome  " + Properties.Settings.Default.Logedin_Name + " !";
            List<Employee> all = new Employee(null,null).GetAll();
            AddtoGride(all);
        }


        float x;
        private void AddtoGride(List<Employee> list)
        {
            x = 0.0f;
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add(new string[] { list[i].Name, list[i].Date, list[i].power, list[i].Phone, list[i].Salary });

            }
            textBox2.Text = (dataGridView1.Rows.Count).ToString();

           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[4].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                x += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            textBox3.Text = (x).ToString();
        }


        bool mousedowen = false;
        Point primarypoint;
        private void txtemp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void txtemp_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void txtemp_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
    }
}
