using GetWeightVersion3.Classes;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtserver.Text = Properties.Settings.Default.Server;
            txtdb.Text     = Properties.Settings.Default.DB;
            txtuser.Text   = Properties.Settings.Default.UserName;
            txtpass.Text   = Properties.Settings.Default.Password;
            string mod = Properties.Settings.Default.Mod;
            if (mod == "Windows")
            {
                radioButton1.Checked = true;
                groupBox2.Enabled = false;
            }
            else
            {
                radioButton2.Checked = true;
                groupBox2.Enabled =true ;
            }


            txtport.Text   = Properties.Settings.Default.PortName;
            txtrate.Text   = Properties.Settings.Default.BaudRate.ToString();
            txtbits.Text   = Properties.Settings.Default.DataBits.ToString();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server   = txtserver.Text;
            Properties.Settings.Default.DB       = txtdb.Text;
          
            
            
            if (radioButton1.Checked)
            {
                Properties.Settings.Default.Mod = "Windows";
               
            }
            else
            {
                Properties.Settings.Default.Mod = "Authornecation";
                Properties.Settings.Default.UserName = txtuser.Text;
                Properties.Settings.Default.Password = txtpass.Text;
               
            }

            Properties.Settings.Default.PortName = txtport.Text;
            Properties.Settings.Default.BaudRate = int.Parse( txtrate.Text);
            Properties.Settings.Default.DataBits = int.Parse(txtbits.Text);

            Properties.Settings.Default.Save();
            Alert.Show("Saved Successfully");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                groupBox2.Enabled = false;
                txtuser.Clear();
                txtpass.Clear();
            }
            else
            {
                radioButton1.Checked = false;
                groupBox2.Enabled = true;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }


        bool mousedowen = false;
        Point primarypoint;
        private void Settings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void Settings_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void Settings_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
