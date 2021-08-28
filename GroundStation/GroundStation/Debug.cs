using System;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class Debug : Form
    {
        public Form1 mainFormObject;
        public Simulation simulationObject;
        private Queue gpsTestData = new Queue();

        public Debug()
        {
            InitializeComponent();
        }

        private void Debug_Load(object sender, EventArgs e)
        {

        }

        private void xAngle_Scroll(object sender, EventArgs e)
        {

            simulationObject.modAngleX = (float)xAngle.Value;
            labelAngleX.Text = xAngle.Value.ToString();
        }

        private void yAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.modAngleY = (float)yAngle.Value;
            labelAngleY.Text = yAngle.Value.ToString();
        }

        private void zAngle_Scroll(object sender, EventArgs e)
        {
            simulationObject.modAngleZ = (float)zAngle.Value;
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

        private void btnGpsTest_Click(object sender, EventArgs e)
        {
            gpsTestData.Enqueue(new float[2] { 41.023375f, 29.017108f });
            gpsTestData.Enqueue(new float[2] { 41.021251f, 29.090002f });
            gpsTestData.Enqueue(new float[2] { 39.929748f, 32.854244f });
            gpsTestData.Enqueue(new float[2] { 40.602914f, 43.094337f });
            testTimer.Interval = 5000;
            testTimer.Tick += gpsTest;
            testTimer.Enabled = true;
        }

        private void gpsTest(object sender, EventArgs e)
        {
            float[] data = (float[]) gpsTestData.Dequeue();
            mainFormObject.updateLocation(data[0], data[1]);
            if (gpsTestData.Count == 0) testTimer.Enabled = false;
        }
    }
}
