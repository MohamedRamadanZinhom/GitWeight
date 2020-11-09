using GetWeightVersion3.Classes;
using GetWeightVersion3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWeightVersion3.UI
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.ShowDialog();
        }

        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogIn f = Application.OpenForms["LogIn"] as LogIn;
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool mousedowen = false;
        Point primarypoint;
        private void MainFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void MainFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void MainFrame_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool iscascaded = false;
        private void button14_Click(object sender, EventArgs e)
        {
            if (iscascaded == false)
            {
                this.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 25);
                iscascaded = true;
            }
            else
            {

                this.SetBounds(0, 0 + this.Location.Y, 1256, 542);
                this.CenterToScreen();
                iscascaded = false;

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DailyReport d = new DailyReport();
            d.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrWhiteSpace(textBox1.Text)) && !((string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrWhiteSpace(textBox2.Text))))
            {
                Car car0 = new Car(textBox1.Text, textBox2.Text);
                Employee emp = new Employee(Properties.Settings.Default.Logedin_Name, Properties.Settings.Default.Logedin_Pass);

                DataAccess DA = new DataAccess();

                if (new Car(this.textBox1.Text, this.textBox2.Text).Get_Query() != null)
                {


                    if (DA.ISCleared(car0) != null)
                    {
                        ScaleFrame s = new ScaleFrame();
                        s.txtcarchar.Text = DA.ISCleared(car0).Caridchar;
                        s.txtcarno.Text = DA.ISCleared(car0).Carid;
                        s.txtprice.Text = DA.ISCleared(car0).Price;
                        s.txtfs.Text = DA.ISCleared(car0).F_Scale;
                        s.txtd1.Text = DA.ISCleared(car0).F_Date;
                        s.txtt1.Text = DA.ISCleared(car0).F_Time;

                        s.txtprice.ReadOnly = true;
                        s.label10.Text = "Seconde Scale";
                        s.button11.BackColor = Color.Gray;
                        s.button10.BackColor = Color.Lime;
                        s.txtemp.Text = Properties.Settings.Default.Logedin_Name;

                        s.ShowDialog();
                    }

                    else
                    {
                        ScaleFrame s = new ScaleFrame();
                        s.txtcarchar.Text = textBox2.Text;
                        s.txtcarno.Text = textBox1.Text;
                        s.label10.Text = "First Scale";
                        s.button11.BackColor = Color.Lime;
                        s.button10.BackColor = Color.Gray;
                        s.txtemp.Text = Properties.Settings.Default.Logedin_Name;

                        s.ShowDialog();
                    }


                }
                else
                {
                    ScaleFrame s = new ScaleFrame();
                    Car car = new Car(textBox1.Text, textBox2.Text);
                    car.Date = DateTime.Now.ToShortDateString();
                    car.Time = DateTime.Now.ToLongTimeString();

                    car.Set_Query();

                    this.UseWaitCursor = true;
                    Thread.Sleep(300);

                    this.UseWaitCursor = false;
                    s.txtcarno.Text = textBox1.Text;
                    s.txtcarchar.Text = textBox2.Text;
                    s.button11.BackColor = Color.Lime;
                    s.button10.BackColor = Color.Gray;
                    s.txtemp.Text = Properties.Settings.Default.Logedin_Name;

                    s.ShowDialog();

                    Alert.Show("New Car Added");
                }
            }
            else
            {
                Alert.Show("Enter The Data First");
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeReport empre = new EmployeeReport();
            empre.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || !char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
