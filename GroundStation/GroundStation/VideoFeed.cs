using Accord.Video;
using Accord.Video.DirectShow;
using Accord.Video.FFMPEG;
using Accord.Video.VFW;
using System.Drawing;
using System.Windows.Forms;

namespace GroundStation
{
    class VideoFeed
    {
        public bool recording = false;
        private Panel videoPanel;
        private VideoCaptureDevice FinalVideo = null;
        private VideoCaptureDeviceForm captureDevice;
        private Bitmap video;
        private Form mainForm;
        //private AVIWriter AVIwriter = new AVIWriter();
        private VideoFileWriter FileWriter = new VideoFileWriter();
        private SaveFileDialog saveAvi;
        public VideoFeed(Panel videoPanel, Form mainForm)
        {
            this.videoPanel = videoPanel;
            this.mainForm = mainForm;
            captureDevice = new VideoCaptureDeviceForm();
            mainForm.FormClosing += MainForm_FormClosing;
        }

        public void startCapture()
        {
            if (captureDevice.ShowDialog(mainForm) == DialogResult.OK)
            {
                VideoCaptureDevice videoSource = captureDevice.VideoDevice;
                FinalVideo = captureDevice.VideoDevice;
                FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                FinalVideo.Start();
            }
        }


        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (recording)
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                videoPanel.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
                //AVIwriter.Quality = 0;
                FileWriter.WriteVideoFrame(video);
                //AVIwriter.AddFrame(video);
            }
            else //If file save is not selected then just show video.
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                videoPanel.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
            }
        }


        public void SelectFileSaveDir()
        {
            saveAvi = new SaveFileDialog
            {
                Filter = "Avi Files (*.avi)|*.avi"
            };
            if (saveAvi.ShowDialog() == DialogResult.OK)
            {
                int h = captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
                int w = captureDevice.VideoDevice.VideoResolution.FrameSize.Width;
                FileWriter.Open(saveAvi.FileName, w, h, 25, VideoCodec.Default, 5000000);
                FileWriter.WriteVideoFrame(video);

                //AVIwriter.Open(saveAvi.FileName, w, h);
                recording = true;
                //FinalVideo = captureDevice.VideoDevice;
                //FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                //FinalVideo.Start();
            }
        }

        public void stopCapture()
        {
            if (recording) { 
            if (FinalVideo == null)
            { return; }
            if (FinalVideo.IsRunning)
            {
                //this.FinalVideo.Stop();
                FileWriter.Close();
                //this.AVIwriter.Close();
                videoPanel.BackgroundImage = null;
            }
                recording = false;
            }
            else
            {
                this.FinalVideo.Stop();
                FileWriter.Close();
                //this.AVIwriter.Close();
                videoPanel.BackgroundImage = null;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalVideo == null)
            { return; }
            if (FinalVideo.IsRunning)
            {
                this.FinalVideo.Stop();
                FileWriter.Close();
                //this.AVIwriter.Close();
            }
        }
    }
}
