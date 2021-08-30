
namespace GroundStation
{
    partial class Debug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debug));
            this.labelAngleZ = new System.Windows.Forms.Label();
            this.labelAngleY = new System.Windows.Forms.Label();
            this.labelAngleX = new System.Windows.Forms.Label();
            this.zAngle = new System.Windows.Forms.TrackBar();
            this.yAngle = new System.Windows.Forms.TrackBar();
            this.xAngle = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.latData = new System.Windows.Forms.TextBox();
            this.lngData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGpsTest = new System.Windows.Forms.Button();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSaveAngle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEl = new System.Windows.Forms.Label();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelRad = new System.Windows.Forms.Label();
            this.camElevationBar = new System.Windows.Forms.TrackBar();
            this.camPolarBar = new System.Windows.Forms.TrackBar();
            this.camRadiusBar = new System.Windows.Forms.TrackBar();
            this.customCamEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camElevationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPolarBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camRadiusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAngleZ
            // 
            this.labelAngleZ.AutoSize = true;
            this.labelAngleZ.Location = new System.Drawing.Point(620, 208);
            this.labelAngleZ.Name = "labelAngleZ";
            this.labelAngleZ.Size = new System.Drawing.Size(16, 17);
            this.labelAngleZ.TabIndex = 52;
            this.labelAngleZ.Text = "0";
            // 
            // labelAngleY
            // 
            this.labelAngleY.AutoSize = true;
            this.labelAngleY.Location = new System.Drawing.Point(384, 208);
            this.labelAngleY.Name = "labelAngleY";
            this.labelAngleY.Size = new System.Drawing.Size(16, 17);
            this.labelAngleY.TabIndex = 51;
            this.labelAngleY.Text = "0";
            // 
            // labelAngleX
            // 
            this.labelAngleX.AutoSize = true;
            this.labelAngleX.Location = new System.Drawing.Point(126, 208);
            this.labelAngleX.Name = "labelAngleX";
            this.labelAngleX.Size = new System.Drawing.Size(16, 17);
            this.labelAngleX.TabIndex = 50;
            this.labelAngleX.Text = "0";
            // 
            // zAngle
            // 
            this.zAngle.Location = new System.Drawing.Point(513, 169);
            this.zAngle.Maximum = 360;
            this.zAngle.Minimum = -360;
            this.zAngle.Name = "zAngle";
            this.zAngle.Size = new System.Drawing.Size(234, 56);
            this.zAngle.TabIndex = 49;
            this.zAngle.Scroll += new System.EventHandler(this.zAngle_Scroll);
            // 
            // yAngle
            // 
            this.yAngle.Location = new System.Drawing.Point(273, 169);
            this.yAngle.Maximum = 360;
            this.yAngle.Minimum = -360;
            this.yAngle.Name = "yAngle";
            this.yAngle.Size = new System.Drawing.Size(234, 56);
            this.yAngle.TabIndex = 48;
            this.yAngle.Scroll += new System.EventHandler(this.yAngle_Scroll);
            // 
            // xAngle
            // 
            this.xAngle.Location = new System.Drawing.Point(19, 169);
            this.xAngle.Maximum = 360;
            this.xAngle.Minimum = -360;
            this.xAngle.Name = "xAngle";
            this.xAngle.Size = new System.Drawing.Size(234, 56);
            this.xAngle.TabIndex = 47;
            this.xAngle.Scroll += new System.EventHandler(this.xAngle_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 53;
            this.button1.Text = "Read Form Sizes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // latData
            // 
            this.latData.Location = new System.Drawing.Point(647, 307);
            this.latData.Name = "latData";
            this.latData.Size = new System.Drawing.Size(100, 22);
            this.latData.TabIndex = 54;
            // 
            // lngData
            // 
            this.lngData.Location = new System.Drawing.Point(647, 335);
            this.lngData.Name = "lngData";
            this.lngData.Size = new System.Drawing.Size(100, 22);
            this.lngData.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Longitude:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 42);
            this.button2.TabIndex = 58;
            this.button2.Text = "Update Location";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Model Angle (X,Y,Z):";
            // 
            // btnGpsTest
            // 
            this.btnGpsTest.Location = new System.Drawing.Point(493, 432);
            this.btnGpsTest.Name = "btnGpsTest";
            this.btnGpsTest.Size = new System.Drawing.Size(128, 49);
            this.btnGpsTest.TabIndex = 68;
            this.btnGpsTest.Text = "Start GPS Test";
            this.btnGpsTest.UseVisualStyleBackColor = true;
            this.btnGpsTest.Click += new System.EventHandler(this.btnGpsTest_Click);
            // 
            // testTimer
            // 
            this.testTimer.Interval = 2000;
            // 
            // btnSaveAngle
            // 
            this.btnSaveAngle.Location = new System.Drawing.Point(627, 231);
            this.btnSaveAngle.Name = "btnSaveAngle";
            this.btnSaveAngle.Size = new System.Drawing.Size(128, 49);
            this.btnSaveAngle.TabIndex = 69;
            this.btnSaveAngle.Text = "Save Mods";
            this.btnSaveAngle.UseVisualStyleBackColor = true;
            this.btnSaveAngle.Click += new System.EventHandler(this.btnSaveAngle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 70;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 42);
            this.button3.TabIndex = 71;
            this.button3.Text = "Update Sat IP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Camera Spherical Pos (Radius,Polar,Elevation):";
            // 
            // labelEl
            // 
            this.labelEl.AutoSize = true;
            this.labelEl.Location = new System.Drawing.Point(620, 93);
            this.labelEl.Name = "labelEl";
            this.labelEl.Size = new System.Drawing.Size(16, 17);
            this.labelEl.TabIndex = 77;
            this.labelEl.Text = "0";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(384, 93);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(16, 17);
            this.labelPol.TabIndex = 76;
            this.labelPol.Text = "0";
            // 
            // labelRad
            // 
            this.labelRad.AutoSize = true;
            this.labelRad.Location = new System.Drawing.Point(126, 93);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(16, 17);
            this.labelRad.TabIndex = 75;
            this.labelRad.Text = "0";
            // 
            // camElevationBar
            // 
            this.camElevationBar.Location = new System.Drawing.Point(513, 54);
            this.camElevationBar.Maximum = 360;
            this.camElevationBar.Minimum = -360;
            this.camElevationBar.Name = "camElevationBar";
            this.camElevationBar.Size = new System.Drawing.Size(234, 56);
            this.camElevationBar.TabIndex = 74;
            this.camElevationBar.Scroll += new System.EventHandler(this.camElevationBar_Scroll);
            // 
            // camPolarBar
            // 
            this.camPolarBar.Location = new System.Drawing.Point(273, 54);
            this.camPolarBar.Maximum = 360;
            this.camPolarBar.Minimum = -360;
            this.camPolarBar.Name = "camPolarBar";
            this.camPolarBar.Size = new System.Drawing.Size(234, 56);
            this.camPolarBar.TabIndex = 73;
            this.camPolarBar.Scroll += new System.EventHandler(this.camPolarBar_Scroll);
            // 
            // camRadiusBar
            // 
            this.camRadiusBar.Location = new System.Drawing.Point(19, 54);
            this.camRadiusBar.Maximum = 360;
            this.camRadiusBar.Minimum = -360;
            this.camRadiusBar.Name = "camRadiusBar";
            this.camRadiusBar.Size = new System.Drawing.Size(234, 56);
            this.camRadiusBar.TabIndex = 72;
            this.camRadiusBar.Scroll += new System.EventHandler(this.camRadiusBar_Scroll);
            // 
            // customCamEnable
            // 
            this.customCamEnable.AutoSize = true;
            this.customCamEnable.Location = new System.Drawing.Point(558, 8);
            this.customCamEnable.Name = "customCamEnable";
            this.customCamEnable.Size = new System.Drawing.Size(74, 21);
            this.customCamEnable.TabIndex = 79;
            this.customCamEnable.Text = "Enable";
            this.customCamEnable.UseVisualStyleBackColor = true;
            this.customCamEnable.CheckedChanged += new System.EventHandler(this.customCamEnable_CheckedChanged);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.customCamEnable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEl);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.camElevationBar);
            this.Controls.Add(this.camPolarBar);
            this.Controls.Add(this.camRadiusBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveAngle);
            this.Controls.Add(this.btnGpsTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lngData);
            this.Controls.Add(this.latData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAngleZ);
            this.Controls.Add(this.labelAngleY);
            this.Controls.Add(this.labelAngleX);
            this.Controls.Add(this.zAngle);
            this.Controls.Add(this.yAngle);
            this.Controls.Add(this.xAngle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Debug";
            this.Text = "Debug Panel";
            this.Load += new System.EventHandler(this.Debug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camElevationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPolarBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camRadiusBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAngleZ;
        private System.Windows.Forms.Label labelAngleY;
        private System.Windows.Forms.Label labelAngleX;
        private System.Windows.Forms.TrackBar zAngle;
        private System.Windows.Forms.TrackBar yAngle;
        private System.Windows.Forms.TrackBar xAngle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox latData;
        private System.Windows.Forms.TextBox lngData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGpsTest;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Button btnSaveAngle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEl;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.TrackBar camElevationBar;
        private System.Windows.Forms.TrackBar camPolarBar;
        private System.Windows.Forms.TrackBar camRadiusBar;
        private System.Windows.Forms.CheckBox customCamEnable;
    }
}