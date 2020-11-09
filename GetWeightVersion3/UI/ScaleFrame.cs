using GetWeightVersion3.Classes;
using GetWeightVersion3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWeightVersion3.UI
{
    public partial class ScaleFrame : Form
    {
        public ScaleFrame()
        {
            InitializeComponent();
        }

        string txt;
        private void ScaleFrame_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
                timer1.Start();

            }
            catch(Exception ex)
            {
                Alert.Show(ex.Message);
                timer1.Stop();
            }
             txt = label10.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool clickedoutscale = false;
        
        private void button2_Click(object sender, EventArgs e)
        {
          

            if (!clickedoutscale)
            {
                txtss.ReadOnly = false;
                this.button2.BackColor = Color.Lime;
                clickedoutscale = true;
                label10.Text = "Out Scale";
            }
            else
            {
                txtss.ReadOnly = true;
                this.button2.BackColor = Color.SaddleBrown;
                clickedoutscale = false;
                label10.Text = txt;
            }
        }


        public static int BAUDRATE =Properties.Settings.Default.BaudRate; // this is baudrate for rise lake 720i scale machine
        public static int DATABITS = Properties.Settings.Default.DataBits;
        public static string PORTNAME = Properties.Settings.Default.PortName;
        public SerialPort _serialPort;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                //<-- This block ensures that no exceptions happen
                if (_serialPort != null && _serialPort.IsOpen)
                    _serialPort.Close();
                if (_serialPort != null)
                    _serialPort.Dispose();
                //<-- End of Block
                try
                {
                    _serialPort = new SerialPort(PORTNAME, BAUDRATE, Parity.None, DATABITS, StopBits.One);       //<-- Creates new SerialPort using the name of the port -->>
                    _serialPort.DataReceived += SerialPortOnDataReceived;       //<-- this event happens everytime when new data is received by the ComPort
                    _serialPort.Open();     //<-- make the comport listen
                }
                catch (IOException eio)
                {

                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show(eio.Message, "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            catch (IOException IOEX)
            {
                MessageBox.Show(IOEX.Message);
            }
        }

        string value;
        private delegate void Closure();
        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            value = "";

            _serialPort.DiscardNull = true;
            _serialPort.ReadTimeout = 1000;

            if (InvokeRequired)     //<-- Makes sure the function is invoked to work properly in the UI-Thread
                BeginInvoke(new Closure(() => { SerialPortOnDataReceived(sender, serialDataReceivedEventArgs); }));     //<-- Function invokes itself
            else
            {
                int dataLength = _serialPort.BytesToRead;

                _serialPort.DiscardNull = true;
                //_serialPort.DiscardOutBuffer();
                byte[] data = new byte[dataLength];


                int nbrDataRead = _serialPort.Read(data, 0, dataLength);

                if (nbrDataRead == 0)
                    return;



                for (int i = 4; i < data.Length - 5; i++)
                {

                    if (data[i] != 0)
                    {
                        value += (char)data[i];
                    }

                }
                if ((value.Length - 5 > 0) && (value != null && value != ""))
                {
                    value = value.Remove(value.Length - 5);
                }

                int outx=-1;
                if (value != "")
                {
                    if (value != null)
                    {
                        if (value.IsNormalized())
                        {
                            if (int.TryParse(value, out outx))
                            {
                                label8.Text = (float.Parse( value)).ToString();
                                //   this.Data.Text = value.ToString();
                            }
                        }

                    }
                }


            }

        }


        bool mousedowen = false;
        Point primarypoint;
        private void ScaleFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousedowen = true;
                primarypoint = new Point(e.X, e.Y);
            }
        }

        private void ScaleFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedowen == true)
            {

                Point ToMovePoint = PointToScreen(new Point(e.X, e.Y));
                ToMovePoint.Offset(-primarypoint.X, -primarypoint.Y);
                this.Location = ToMovePoint;

            }
        }

        private void ScaleFrame_MouseUp(object sender, MouseEventArgs e)
        {
            mousedowen = false;
        }



       

        private void txtfs_Click(object sender, EventArgs e)
        {
            if (txt == "First Scale" || label10.Text == "Out Scale")
            {

                if (txtprice.Text == "0")
                {
                    Alert.Show("Enter Scale Price");
                }
                else
                {
                    if (float.Parse(label8.Text) == 0)
                    {
                        Alert.Show("The Scale Weight Not Exist");
                    }
                    else
                    {
                        whoClicked(sender, e);
                        if (float.Parse(txtfs.Text) != 0)
                        {
                            txtd1.Text = DateTime.Now.ToShortDateString();
                            txtt1.Text = DateTime.Now.ToLongTimeString();
                        }
                    }
                }

            }
        }

        private void whoClicked(object sender, EventArgs e)
        {
            TextBox text1 = sender as TextBox;

            text1.Text = label8.Text;
        }

        private void txtss_Click(object sender, EventArgs e)
        {
            if (txt == "Seconde Scale" && label10.Text != "Out Scale")
            {
                if (float.Parse( label8.Text )== 0)
                {
                    Alert.Show("The Scale Weight Not Exist");
                }
                else
                {
                    whoClicked(sender, e);
                    if (float.Parse(txtss.Text) != 0)
                    {
                        txtd2.Text = DateTime.Now.ToShortDateString();
                        txtt2.Text = DateTime.Now.ToLongTimeString();
                    }
                }
            }
           
        }

        private void ScaleFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Scale scale = new Scale();

            switch (label10.Text)
            {
                case "First Scale":

                    scale.Price = txtprice.Text;
                    scale.Emp_Id = txtemp.Text;
                    scale.Carid = txtcarno.Text;
                    scale.Caridchar = txtcarchar.Text;
                    scale.F_Scale = txtfs.Text;
                    scale.F_Date = txtd1.Text;
                    scale.F_Time = txtt1.Text;

                    if (txtfs.Text != "0" && !string.IsNullOrWhiteSpace(txtfs.Text) && !string.IsNullOrEmpty(txtfs.Text))
                    {
                        if (float.Parse(txtfs.Text) > 0)
                        {
                            new DataAccess().SetFirstScale(scale);
                        }
                    }

                    break;

                case "Seconde Scale":

                    scale.S_Scale = txtss.Text;
                    scale.Clear_Scale = txtcs.Text;
                    scale.S_Date = txtd2.Text;
                    scale.S_Time = txtt2.Text;

                    scale.Price = txtprice.Text;
                    scale.Emp_Id = txtemp.Text;
                    scale.Carid = txtcarno.Text;
                    scale.Caridchar = txtcarchar.Text;
                    scale.F_Scale = txtfs.Text;
                    scale.F_Date = txtd1.Text;
                    scale.F_Time = txtt1.Text;

                    if (txtfs.Text != "0" && !string.IsNullOrWhiteSpace(txtfs.Text) && !string.IsNullOrEmpty(txtfs.Text))
                    {
                        if ((txtss.Text != "0" && !string.IsNullOrWhiteSpace(txtss.Text) && !string.IsNullOrEmpty(txtss.Text)))
                        {
                            if (float.Parse(txtfs.Text) > 0 && float.Parse(txtss.Text) > 0 && float.Parse(txtcs.Text) > 0)
                            {
                                new DataAccess().SetSecondeScale(scale);
                            }
                        }

                    }
                    break;

                case "Out Scale":

                    scale.S_Scale = txtss.Text;
                    scale.Clear_Scale = txtcs.Text;
                    scale.S_Date = txtd2.Text;
                    scale.S_Time = txtt2.Text;

                    scale.Price = txtprice.Text;
                    scale.Emp_Id = txtemp.Text;
                    scale.Carid = txtcarno.Text;
                    scale.Caridchar = txtcarchar.Text;
                    scale.F_Scale = txtfs.Text;
                    scale.F_Date = txtd1.Text;
                    scale.F_Time = txtt1.Text;

                    if (txtfs.Text != "0" && !string.IsNullOrWhiteSpace(txtfs.Text) && !string.IsNullOrEmpty(txtfs.Text))
                    {
                        if ((txtss.Text != "0" && !string.IsNullOrWhiteSpace(txtss.Text) && !string.IsNullOrEmpty(txtss.Text)))
                        {
                            if (float.Parse(txtfs.Text) > 0 && float.Parse(txtss.Text) > 0 && float.Parse(txtcs.Text) > 0)
                            {
                                Car car = new Car(scale.Carid,scale.Caridchar);
                                if (new DataAccess().ISCleared(car) ==null)
                                {
                                    new DataAccess().SetFirstScale(scale);
                                }
                                 new DataAccess().SetSecondeScale(scale);
                            }
                        }
                    }
                    break;

            }

            timer1.Enabled = false;
            timer1.Stop();
            _serialPort.Close();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrWhiteSpace(txtprice.Text))
            {
                if (txtprice.Text == "")
                {
                    txtprice.Text = "0";
                }
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back  || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtss_TextChanged(object sender, EventArgs e)
        {
            if (label10.Text == "Out Scale")
            {
                txtd2.Text = DateTime.Now.ToShortDateString();
                txtt2.Text = DateTime.Now.ToLongTimeString();
                if (txtfs.Text != "0" && !string.IsNullOrWhiteSpace(txtfs.Text) && !string.IsNullOrEmpty(txtfs.Text))
                {
                    if ((txtss.Text != "0" && !string.IsNullOrWhiteSpace(txtss.Text) && !string.IsNullOrEmpty(txtss.Text)))
                    {
                        txtcs.Text = (Math.Abs(float.Parse(txtfs.Text) - float.Parse(txtss.Text))).ToString();
                    }
                }
            }

            if (label10.Text == "Seconde Scale")
            {
                if (txtfs.Text != "0" && !string.IsNullOrWhiteSpace(txtfs.Text) && !string.IsNullOrEmpty(txtfs.Text))
                {
                    if ((txtss.Text != "0" && !string.IsNullOrWhiteSpace(txtss.Text) && !string.IsNullOrEmpty(txtss.Text)))
                    {
                        txtcs.Text = (Math.Abs(float.Parse(txtfs.Text) - float.Parse(txtss.Text))).ToString();
                    }
                }
            }
        }


    }
}
