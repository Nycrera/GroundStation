using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GroundStation
{
    public partial class Form1 : Form
    {
        public Simulation simulationObject;
        private VideoFeed videoFeed;
        private Mavlink mavlink;
        private DateTime FirstTelemetryTime;
        private bool didOperationBegin = false;
        public Form1()
        {
            this.FormClosed += Form1_FormClosed;
            InitializeComponent();
            videoFeed = new VideoFeed(camera_display, this);
            mavlink = new Mavlink(this,UpdateData,byteRecv,byteTrans,PermissionTimer,byteTotal,videoStatus);
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
                    mavlink.SetVideoData(size,text);
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
            mavlink.Connect_Event(sender,e);
            connectionLabel.BackColor = Color.Green;
            connectionLabel.Text = "Connected";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.Position = new GMap.NET.PointLatLng(41.007848569582244, 28.98043706315273); // Ininitally point to Istanbul, since no data is present
            //gMap.Position = new GMap.NET.PointLatLng(45,45); // An example usage of lat long

        }

        public void updateLocation(float lat, float lng)
        {
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        new GMap.NET.PointLatLng(lat, lng),
        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);

            gMap.Overlays.Clear();
            gMap.Overlays.Add(markers);
            gMap.Update();
        }

        private void UpdateData()
        {
            // 0->team_id, 1->pkg_number, 2->pressure, 3->alt, 4->temp, 5->status, 6->pitch, 7->roll, 8->yaw, 9->turn_number, 10->vid_info  // (subject to change)
            string[] data = mavlink.Splitted_Telemetry;
            InsertDataRow(data);

            // USE INCOMING DATA HERE
            if (!didOperationBegin) //Means that this is our first package, therefore initalize the begin time.
            {
                FirstTelemetryTime = DateTime.Now;
                didOperationBegin = true; // I don't like using flags but anyways :S
            }
            double operationTime = Math.Round((FirstTelemetryTime - DateTime.Now).TotalSeconds,2); // I did round to 2 decimal places. Idk how this would look.
            packGraph.Series[0].Points.AddXY(operationTime, Int32.Parse(data[1]));
            presGraph.Series[0].Points.AddXY(operationTime, Double.Parse(data[2]));
            altGraph.Series[0].Points.AddXY(operationTime, Double.Parse(data[3]));
            tempGraph.Series[0].Points.AddXY(operationTime, Double.Parse(data[4]));
            statusLabel.Text = data[5];
            simulationObject.angleX = float.Parse(data[6]);
            simulationObject.angleY = float.Parse(data[7]);
            simulationObject.angleZ = float.Parse(data[8]);
            
        }

        private void InsertDataRow(string[] data)
        {
            // This restructing could be removed when the package is in order when got from mavlink.
            // I just filled unknown data with ??
            string[] NewRow = { data[0], data[1], "??", data[2], data[3], "??", data[4], "??", "??", "??", "??", data[5], data[6], data[7], data[8], data[9], data[10]};
            dataGrid.Rows.Add(NewRow);
        }

        private void selectVidButton_Click(object sender, EventArgs e)
        {
            videoFeed.SelectFileSaveDir();
        }

        private void startVidButton_Click(object sender, EventArgs e)
        {
            videoFeed.startCapture();
        }

        private void stopVidButton_Click(object sender, EventArgs e)
        {
            videoFeed.stopCapture();
        }

        private void activeAlBut_Click(object sender, EventArgs e)
        {
            mavlink.Manual_Motor_Always_Click(sender, e);
        }

        private void active10SecBut_Click(object sender, EventArgs e)
        {
            mavlink.TenSecond_Active_Click(sender, e);
        }

        private void releaseBut_Click(object sender, EventArgs e)
        {
            mavlink.Manual_Release_Click(sender, e);
        }

        private void send_video_Click(object sender, EventArgs e)
        {
            mavlink.SEND_VIDEO_Click(sender, e);
        }
    }
}
