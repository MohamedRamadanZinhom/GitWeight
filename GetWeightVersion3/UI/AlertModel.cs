using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GetWeightVersion3.UI
{


    public partial class AlertModel : Form
    {
       

        public AlertModel()
        {
            InitializeComponent();
        }
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private string message;

        public string Message
        {
            get { return this.message; }
            set { message = value; this.label1.Text = value; }
        }

        public Color Backcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = Backcolor; this.BackColor = value; }
        }

        public enum Action { Start, Wait, Close }

        private Action action;
        private int x, y;

        public void ShowAlert(string message)
        {

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 0; i < 10; i++)
            {

                fname = "alert" + i.ToString();
                AlertModel item = (AlertModel)Application.OpenForms[fname];
                if (item == null)
                {

                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * (4 + i);
                    this.Location = new Point(x, y);
                    break;

                }


            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.label1.Text = message;
            this.Show();
            this.action = Action.Start;
            this.timer1.Interval = 1;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {

                case Action.Wait:

                    timer1.Interval = 2000;
                    action = Action.Close;
                    break;
                case Action.Start:
                   
                   
                   
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {

                        if (this.Opacity == 1.0)
                        {
                            action = Action.Wait;
                        }

                    }

                    break;

                case Action.Close:

                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    player.controls.stop();
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = Action.Close;
        }

        private void AlertModel_Load(object sender, EventArgs e)
        {
            try
            {
                player.URL = "Music/intuition-561.mp3";
                player.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







    }
}
