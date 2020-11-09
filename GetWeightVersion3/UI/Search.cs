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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtcarchar.Text) && string.IsNullOrWhiteSpace(txtcarchar.Text)) && (string.IsNullOrEmpty(txtcarno.Text) && string.IsNullOrWhiteSpace(txtcarno.Text)))
            {
                Alert.Show("Enter The Data To Search");
            }
            else
            {
                dataGridView1.Rows.Clear();
                Car car = new Car(txtcarno.Text, txtcarchar.Text);
                List<Scale> all = new DataAccess().Search(car, date1.Value, date2.Value);
                for (int i = 0; i < all.Count; i++)
                {
                    dataGridView1.Rows.Add(new string[] { all[i].Emp_Id, all[i].Carid, all[i].Caridchar, all[i].F_Scale, all[i].S_Scale, all[i].Clear_Scale, all[i].Price });

                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtemp.Text  = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtid.Text   = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtchar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfs.Text   = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtss.Text   = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcs.Text   = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtprice.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool mousedowen = false;
        Point primarypoint;
        private void Search_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void Search_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void Search_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
    }
}
