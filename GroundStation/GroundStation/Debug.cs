﻿using System;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class Debug : Form
    {
        public Form1 mainFormObject;
        public Simulation simulationObject;

        public Debug()
        {
            InitializeComponent();
        }

        private void Debug_Load(object sender, EventArgs e)
        {

        }

        private void xAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.angleX = (float)xAngle.Value;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = mainFormObject;
            MessageBox.Show(form.Size.Width + " " + form.Size.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = mainFormObject;
            try
            { 
            form.updateLocation(float.Parse(latData.Text), float.Parse(lngData.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to update the location, check data.");
            }
        }

        private void xPos_Scroll(object sender, EventArgs e)
        {
            simulationObject.position.X = (float) xPos.Value;
            labelXPos.Text = xPos.Value.ToString();
        }

        private void yPos_Scroll(object sender, EventArgs e)
        {
            simulationObject.position.Y = (float)yPos.Value;
            labelYPos.Text = yPos.Value.ToString();
        }

        private void zPos_Scroll(object sender, EventArgs e)
        {
            simulationObject.position.Z = (float)zPos.Value;
            labelZPos.Text = zPos.Value.ToString();
        }
    }
}
