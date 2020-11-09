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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddnewExpenses add = new AddnewExpenses();
            add.ShowDialog();
        }

        float empsalary,cost;
        private void button1_Click(object sender, EventArgs e)
        {
            allemployee();
            allexpensess();
        }

        private void allemployee()
        {
            empsalary = 0.0f;
            List<Employee> all = new Employee(null, null).GetAll();
            int count = all.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new string[] { all[i].Name, all[i].Salary });
            }

            for (int i = 0; i < count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    empsalary += float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            label2.Text = empsalary.ToString();
        
        }
        private void allexpensess()
        {
            cost = 0.0f;
            List<Expensess> all = new DataAccess().GetAllExpensess(date1.Value.ToString(),date2.Value.ToString());
            int count = all.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView2.Rows.Add(new string[] { all[i].Cost, all[i].DESC });
            }

            for (int i = 0; i < count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView2.Rows[i].Cells[0].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView2.Rows[i].Cells[0].Value.ToString()))
                {
                    cost += float.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
            }
            label9.Text = cost.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                txtcost.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtdes.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtemp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtsalary.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }


        bool mousedowen = false;
        Point primarypoint;
        private void Expenses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void Expenses_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void Expenses_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
    }
}
