﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
