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
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            txtemp.Text = " Welcome  "+Properties.Settings.Default.Logedin_Name +" !";
            List<Scale> all = new DataAccess().GetAllScale(DateTime.Now.ToShortDateString() );

            AddtoGride(all);


        }

        float x;
        private void AddtoGride(List<Scale> list)
        {
            x = 0.0f;
            for(int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows.Add(new string[] { list[i].Emp_Id, list[i].Carid, list[i].Caridchar, list[i].F_Scale, list[i].S_Scale, list[i].Clear_Scale, list[i].Price });

            }
            textBox2.Text = (dataGridView1.Rows.Count).ToString();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[6].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                x += float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }

            textBox3.Text = (x).ToString();
        }


        bool mousedowen = false;
        Point primarypoint;
        private void DailyReport_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void DailyReport_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void DailyReport_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
    }
}
