using KnobControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArduinoGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Form1_Shown);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort1.Open();
            label9.Visible = true;
            serialPort1.WriteLine("C");
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting(); 

            if (indata.Contains("D"))
            {
                Invoke(new Action(() =>
                {
                    label7.Visible = true;
                }));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("A");
        }

        private void knobControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("B");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void zadajbox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(zadajbox1.Text, out value))
            {
                if (value >= -60 && value <= 60)
                {

                }
                else
                {
                    zadajbox1.Text = ""; 
                }
            }
            else if (zadajbox1.Text == "" || zadajbox1.Text == "-")
            {

            }
            else
            {
                zadajbox1.Text = ""; 
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(zadajbox1.Text, out value))
            {
                if (value >= -60 && value <= 60)
                {
                    serialPort1.WriteLine(zadajbox1.Text.Trim());
                }
                else
                {
                    zadajbox1.Text = ""; 
                    MessageBox.Show("Błąd złego zakresu");
                }
            }
            else if (zadajbox1.Text == "" || zadajbox1.Text == "-")
            {
                MessageBox.Show("Błąd liczby");
            }
            else
            {
                zadajbox1.Text = ""; 
                MessageBox.Show("Błąd liczby");
            }
            

        }
        int ostatnie_pol = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pokretlo1.Value != ostatnie_pol) 
            {
                ostatnie_pol = pokretlo1.Value; 
                serialPort1.WriteLine(pokretlo1.Value.ToString()); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
