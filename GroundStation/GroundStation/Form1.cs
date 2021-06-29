using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class Form1 : Form
    {

        public Simulation simulationObject;
        public Form1()
        {
            this.FormClosed += Form1_FormClosed;
            InitializeComponent();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public IntPtr getDrawSurface()
        {
            return simulation_display.Handle;
        }

        private void slct_file_Click(object sender, EventArgs e) // TODO: not working for now need to implement file selection
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort1.PortName = portCombo.Text;
            //SerialPort1.BaudRate = 9600;
            SerialPort1.BaudRate = 115200;
            SerialPort1.ReadBufferSize = SerialPort1.ReadBufferSize + 4096;
            SerialPort1.WriteBufferSize = SerialPort1.WriteBufferSize + 4096;
            SerialPort1.Open();

            connectionLabel.BackColor = Color.Green;
            connectionLabel.Text = "Connected";
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void xAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.angleX = (float) xAngle.Value;
            labelAngleX.Text = xAngle.Value.ToString();
        }

        private void yAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.angleY = (float)yAngle.Value;
            labelAngleY.Text = yAngle.Value.ToString();
        }

        private void zAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.angleZ = (float)zAngle.Value;
            labelAngleZ.Text = zAngle.Value.ToString();
        }

    }
}
