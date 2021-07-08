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
        public Form1()
        {
            this.FormClosed += Form1_FormClosed;
            InitializeComponent();
            videoFeed = new VideoFeed(camera_display, this);
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

        private void Form1_Load_1(object sender, EventArgs e)
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
    }
}
