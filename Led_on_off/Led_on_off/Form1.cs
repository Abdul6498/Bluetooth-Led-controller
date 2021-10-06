using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Led_on_off
{
    public partial class Form1 : Form
    {
        private SerialPort myport;
        public Form1()
        {
            
            InitializeComponent();
            init();
        }


        private void init()
        {
            try
            {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM1";
            myport.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("COM PORT NOT FOUND", "COM9");
            }

            on_button.Enabled = true;
            on_btn2.Enabled = true;
            on_btn3.Enabled = true;
            on_btn4.Enabled = true;
            on_btn5.Enabled = true;
            on_btn6.Enabled = true;
            on_btn7.Enabled = true;
            on_btn8.Enabled = true;

            off_button.Enabled = false;
            off_btn2.Enabled = false;
            off_btn3.Enabled = false;
            off_btn4.Enabled = false;
            off_btn5.Enabled = false;
            off_btn6.Enabled = false;
            off_btn7.Enabled = false;
            off_btn8.Enabled = false;

        }
        /*private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = textBox1.Text;
                myport.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("COM PORT NOT FOUND");
            }
        }*/

        private void on_button_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Q");
            on_button.Enabled = false;
            off_button.Enabled = true;

        }

        private void off_button_Click(object sender, EventArgs e)
        {
            myport.WriteLine("A");
            on_button.Enabled = true;
            off_button.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myport.WriteLine("H");
            on_btn6.Enabled = true;
            off_btn6.Enabled = false;

        }

        private void off_btn8_Click(object sender, EventArgs e)
        {
            myport.WriteLine("K");
            on_btn8.Enabled = true;
            off_btn8.Enabled = false;

        }

        private void on_btn2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("W");
            on_btn2.Enabled = false;
            off_btn2.Enabled = true;
        }

        private void on_btn3_Click(object sender, EventArgs e)
        {
            myport.WriteLine("E");
            on_btn3.Enabled = false;
            off_btn3.Enabled = true;
        }

        private void on_btn4_Click(object sender, EventArgs e)
        {
            myport.WriteLine("R");
            on_btn4.Enabled = false;
            off_btn4.Enabled = true;
        }

        private void off_btn2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("S");
            on_btn2.Enabled = true;
            off_btn2.Enabled = false;
        }

        private void off_btn3_Click(object sender, EventArgs e)
        {
            myport.WriteLine("D");
            on_btn3.Enabled = true;
            off_btn3.Enabled = false;

        }

        private void off_btn4_Click(object sender, EventArgs e)
        {
            myport.WriteLine("F");
            on_btn4.Enabled = true;
            off_btn4.Enabled = false;

        }

        private void on_btn5_Click(object sender, EventArgs e)
        {
            myport.WriteLine("T");
            on_btn5.Enabled = false;
            off_btn5.Enabled = true;
        }

        private void on_btn6_Click(object sender, EventArgs e)
        {
            myport.WriteLine("Y");
            on_btn6.Enabled = false;
            off_btn6.Enabled = true;
        }

        private void on_btn7_Click(object sender, EventArgs e)
        {
            myport.WriteLine("U");
            on_btn7.Enabled = false;
            off_btn7.Enabled = true;
        }

        private void on_btn8_Click(object sender, EventArgs e)
        {
            myport.WriteLine("I");
            on_btn8.Enabled = false;
            off_btn8.Enabled = true;
        }

        private void off_btn5_Click(object sender, EventArgs e)
        {
            myport.WriteLine("G");
            on_btn5.Enabled = true;
            off_btn5.Enabled = false;

        }

        private void off_btn7_Click(object sender, EventArgs e)
        {
            myport.WriteLine("J");
            on_btn7.Enabled = true;
            off_btn7.Enabled = false;

        }
    }
}
