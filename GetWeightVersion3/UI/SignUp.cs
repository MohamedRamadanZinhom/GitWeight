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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private bool check()
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {

                return false;
            }
            else if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {

                return false;
            }
            else if (string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrWhiteSpace(textBox3.Text))
            {

                return false;
            }
            else if (string.IsNullOrEmpty(textBox4.Text) && string.IsNullOrWhiteSpace(textBox4.Text))
            {

                return false;
            }
            else if (string.IsNullOrEmpty(textBox5.Text) && string.IsNullOrWhiteSpace(textBox5.Text))
            {

                return false;
            }
            else
            {
                return true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == false)
            {
                Alert.Show("Please Enter the Employee Data");
            }
            else
            {
                Employee emp = new Employee(textBox4.Text, textBox6.Text).Get_Query() as Employee;

                if (emp != null)
                {
                    Employee emp1 = new Employee(this.textBox1.Text, this.textBox2.Text);
                    emp1.power = textBox3.Text;
                    emp1.Phone = textBox5.Text;
                    emp1.Salary = textBox7.Text;

                    emp1.Set_Query();

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                }
                else
                {
                    Alert.Show("the Manager Code or User Name was invaled ");
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text.ToString();
        }


        bool mousedowen = false;
        Point primarypoint;
        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void SignUp_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }

        private string oldid, oldcode;

        private void SignUp_Load(object sender, EventArgs e)
        {
            Employee emp = new Employee(Properties.Settings.Default.Logedin_Name, Properties.Settings.Default.Logedin_Pass).Get_Query() as Employee; ;
            if (emp.Get_Query() != null)
            {
                textBox1.Text = emp.Name;
                textBox2.Text = emp.Code;
                textBox3.Text = emp.power;
                textBox5.Text = emp.Phone;
                textBox7.Text = emp.Salary;
            }
            this.oldid = emp.Name;
            this.oldcode = emp.Code;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee(null, null);
            emp.Name = textBox1.Text;
            emp.Code = textBox2.Text;
            emp.power = textBox3.Text;
            emp.Phone = textBox5.Text;
            emp.Salary = textBox7.Text;
           
           
           emp.Reset_Query();
           Properties.Settings.Default.Logedin_Name = emp.Name;
           Properties.Settings.Default.Logedin_Pass = emp.Code;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(textBox1.Text, textBox2.Text);
            emp.Name = textBox1.Text;
            emp.Code = textBox2.Text;
            if (emp.Name == Properties.Settings.Default.Logedin_Name && emp.Code == Properties.Settings.Default.Logedin_Pass)
            {
                DialogResult result= MessageBox.Show("You will delete your Acount are you sure you want to Continue ..!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    emp.Remove();

                LogIn log = Application.OpenForms["LogIn"] as LogIn;
                MainFrame f = Application.OpenForms["MainFrame"] as MainFrame;
                foreach (Control c in log.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Clear();
                    }
                }
                log.Show();
                Close();
                f.Close();
                }
                else
                {
                 return;
                }
               
            }
            else
            { 
              Employee employee = new Employee(textBox4.Text, textBox6.Text).Get_Query() as Employee;

              if (employee != null)
              {
                  Employee emp1 = new Employee(this.textBox1.Text, this.textBox2.Text);
                  emp1.power = textBox3.Text;
                  emp1.Phone = textBox5.Text;
                  emp1.Salary = textBox7.Text;
                  emp.Remove();

              }
              else
              {
                  Alert.Show("Enter Manager Key !");
              }
           

        }
    }
    }
}
