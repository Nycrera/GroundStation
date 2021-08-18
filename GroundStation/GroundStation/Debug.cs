using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class Debug : Form
    {
        public Form1 mainFormObject;
        public Simulation simulationObject;
        private double[] dataArr = new double[] { 31.20, 31.40, 32.60, 33.20, 31.60, 31.40, 33.10, 34.40, 34.50, 42.40, 40.50, 45.90, 49.10, 50.30, 53.60, 53.70, 52.90, 58.50, 59.90, 54.80, 56.00, 57.50, 54.20, 58.40, 63.50, 58.60, 58.50, 59.50, 65.50, 68.90 };
        private int count = 0;
        private int pkgCount = 0;
        Random rnd = new Random();
        private DateTime FirstTelemetryTime;
        private bool didOperationBegin = false;

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

        private void button3_Click(object sender, EventArgs e)
        {
            // 0->team_id, 1->pkg_number, 2->pressure, 3->alt, 4->temp, 5-> BATTERY_VOLT,6 ->status, 7 ->pitch, 8->roll, 9->yaw, 10->turn_number, 11->vid_info  // (subject to change)
                string[] insertedData = new string[12];
                for(int i=0;i<dataGrid.Rows[0].Cells.Count; i++)
                {
                    insertedData[i] = dataGrid.Rows[0].Cells[i].Value.ToString();
                }
                mainFormObject.mavlink.Splitted_Telemetry = insertedData;
                mainFormObject.UpdateData(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           string[] NewRow = { "29799", (pkgCount+1).ToString(), DateTime.Now.ToString(), "1017.60", (1.5+(1-((double) rnd.Next(1,5)/10))).ToString(), "0", Math.Round(dataArr[count], 2).ToString(), "3.3", "41.007848569582244", "28.98043706315273", "2.00", "WAITING", (90 + (1 - ((double)rnd.Next(1, 5) / 10))).ToString(), (2.5 + (1 - ((double)rnd.Next(1, 5) / 10))).ToString(), (2.5 + (1 - ((double)rnd.Next(1, 5) / 10))).ToString(), "0.00", "HAYIR" };
            mainFormObject.dataGrid.Rows.Add(NewRow);
            if (!didOperationBegin) //Means that this is our first package, therefore initalize the begin time.
            {
                FirstTelemetryTime = DateTime.Now;
                didOperationBegin = true; // I don't like using flags but anyways :S
            }
            double operationTime = Math.Round((DateTime.Now - FirstTelemetryTime).TotalSeconds, 2); // I did round to 2 decimal places. Idk how this would look.
            mainFormObject.packGraph.Series[0].Points.AddXY(operationTime, Int32.Parse(NewRow[1]));
            mainFormObject.presGraph.Series[0].Points.AddXY(operationTime, Double.Parse(NewRow[3]));
            mainFormObject.altGraph.Series[0].Points.AddXY(operationTime, Double.Parse(NewRow[4]));
            mainFormObject.tempGraph.Series[0].Points.AddXY(operationTime, Double.Parse(NewRow[6]));
            mainFormObject.voltageGraph.Series[0].Points.AddXY(operationTime, Double.Parse(NewRow[7]));
            count++;
            pkgCount++;
            if (count == dataArr.Length) count--;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainFormObject.connectionLabel.BackColor = Color.Green;
            mainFormObject.connectionLabel.Text = "Connected";
        }
    }
}
