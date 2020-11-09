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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

       
        public bool showpassword { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "User Name";
                textBox1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.White;
            }

            if (textBox2.Text == "Password")
            {
                return;
            }
            else
            {
                if (showpassword == true)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Password";
                textBox2.UseSystemPasswordChar = false;
                textBox2.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                showpassword = true;
            }
            else
            {

                showpassword = false;
            }


            if (textBox2.Text == "Password")
            {
                return;
            }
            else
            {
                if (showpassword == true)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                showpassword = true;
            }
            else
            {

                showpassword = false;
            }


            if (textBox2.Text == "Password")
            {
                return;
            }
            else
            {
                if (showpassword == true)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }


        bool mousedowen = false;
        Point primarypoint;
        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }
        private int SecurityKey ;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecurityKey > 4)
                {
                    MessageBox.Show("you have enter the security key in invaled way for 5 time the App will Exit");
                    Thread.Sleep(200);
                    Application.Exit();

                }

                if (new Employee(this.textBox1.Text, this.textBox2.Text).Get_Query() != null)
                {

                    MainFrame f = new MainFrame();
                    f.Show();
                    Alert.Show("Log in successfuly !");
                    Properties.Settings.Default.Logedin_Name = textBox1.Text;
                    Properties.Settings.Default.Logedin_Pass = textBox2.Text;
                    Properties.Settings.Default.Save();
                    this.Hide();

                }
                else
                {
                    Alert.Show("Log in Faild !");

                    SecurityKey++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstuse == "0")
            {
                Settings s = new Settings();
                s.ShowDialog();
                Properties.Settings.Default.firstuse = "1";
                Properties.Settings.Default.Save();
            }

          
               
                
            
        }
    }
}
