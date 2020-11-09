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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
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
                    dataGridView1.Rows.Add(new string[] { all[i].Emp_Id, all[i].Carid, all[i].Caridchar, all[i].F_Scale, all[i].S_Scale, all[i].Clear_Scale, all[i].F_Date, all[i].S_Date, all[i].Price, all[i].F_Time, all[i].S_Time });

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    txtemp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtchar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtfs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtss.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtcs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    label5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    label6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txtprice.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    time1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    time2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                }
            }
        }

        bool mousedowen = false;
        Point primarypoint;
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scale scale = new Scale();
            scale.Price = txtprice.Text;
            scale.Carid = txtid.Text;
            scale.Caridchar = txtchar.Text;
            scale.F_Scale = txtfs.Text;
            scale.S_Scale = txtss.Text;
            scale.Clear_Scale = txtcs.Text;
            scale.Emp_Id = txtemp.Text;
            scale.F_Date = label5.Text;
            scale.F_Time = time1.Text;
            scale.S_Time = time2.Text;
            new DataAccess().ResetScale(scale);          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Scale scale = new Scale();
            scale.Price = txtprice.Text;
            scale.Carid = txtid.Text;
            scale.Caridchar = txtchar.Text;
            scale.F_Scale = txtfs.Text;
            scale.S_Scale = txtss.Text;
            scale.Clear_Scale = txtcs.Text;
            scale.Emp_Id = txtemp.Text;
            scale.F_Date = label5.Text;
            scale.F_Time = time1.Text;
            scale.S_Time = time2.Text;
            new DataAccess().RemoveScale(scale);            
        }
    }
}
