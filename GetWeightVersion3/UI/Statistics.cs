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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Scale> all = new DataAccess().GetAllScale(date1.Value.ToString(),date2.Value.ToString());

            Action( all);


        }

        float x;
        private void Action(List<Scale> all)
        {
            x = 0.0f ;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < all.Count; i++)
            {
                dataGridView1.Rows.Add(new string[] { all[i].Emp_Id, all[i].Carid, all[i].Caridchar, all[i].F_Scale, all[i].S_Scale, all[i].Clear_Scale, all[i].Price });

            }

            txtcount.Text = dataGridView1.Rows.Count.ToString();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[6].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                    x += float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            txtcost.Text = (x).ToString();

            txtaverage.Text = (float.Parse(txtcost.Text) / float.Parse(txtcount.Text)).ToString();

           txtmedian.Text= GetMedian(getset()).ToString();
            
            txtsd.Text = StanderDeviation(getset()).ToString();


        
        }
        int mid=0;
        float median;
        private float GetMedian(List<float> set)
        {
            mid = 0;
            median = 0.0f;

            List<float> sorted = new List<float>() ;
           
            int size;
            if (set == null || set.Count == 0)
            {
              

            }
            else
            {
                
                sorted = set;

                sorted.Sort();
                 size = sorted.Count;
               
                if (size % 2 == 0)
                {
                    mid = size / 2;
                }
                else
                {
                    mid = (size - 1) / 2;
                }
                median = sorted[mid];
            }
            

            return median;
        }

        private List<float> getset()
        {
            float mony = 0.0f;
            List<float> Set = new List<float>();



            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[6].Value.ToString()) && !string.IsNullOrWhiteSpace(dataGridView1.Rows[i].Cells[6].Value.ToString()))
                {
                    mony = float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                Set.Add(mony);
            }

            return Set;
        }
       
        float stander = 0.0f;
        private float StanderDeviation(List<float>Set )
        {
            stander = 0.0f;
            if (Set != null || Set.Count <= 0)
            {
                try
                {


                    float AVG = Set.Average();


                    float SumSq = 0.0f;

                    for (int i = 0; i < Set.Count; i++)
                    {

                        SumSq += float.Parse(Math.Pow((Set[i] - AVG), 2).ToString());

                    }

                    stander = float.Parse(Math.Sqrt(SumSq / (Set.Count)).ToString());
                }
                catch(Exception ex)
                {
                    Alert.Show(ex.Message);
                }
            }

                return stander;
        }





        bool mousedowen = false;
        Point primarypoint;
        private void Statistics_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void Statistics_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void Statistics_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }










    }
}
