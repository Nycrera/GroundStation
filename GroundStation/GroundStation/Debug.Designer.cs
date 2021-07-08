
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
            this.labelZPos = new System.Windows.Forms.Label();
            this.labelYPos = new System.Windows.Forms.Label();
            this.labelXPos = new System.Windows.Forms.Label();
            this.zPos = new System.Windows.Forms.TrackBar();
            this.yPos = new System.Windows.Forms.TrackBar();
            this.xPos = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos)).BeginInit();
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
            this.labelAngleX.Size = new System.Drawing.Size(24, 17);
            this.labelAngleX.TabIndex = 50;
            this.labelAngleX.Text = "90";
            // 
            // zAngle
            // 
            this.zAngle.Location = new System.Drawing.Point(513, 169);
            this.zAngle.Maximum = 360;
            this.zAngle.Name = "zAngle";
            this.zAngle.Size = new System.Drawing.Size(234, 56);
            this.zAngle.TabIndex = 49;
            this.zAngle.Scroll += new System.EventHandler(this.zAngle_Scroll);
            // 
            // yAngle
            // 
            this.yAngle.Location = new System.Drawing.Point(273, 169);
            this.yAngle.Maximum = 360;
            this.yAngle.Name = "yAngle";
            this.yAngle.Size = new System.Drawing.Size(234, 56);
            this.yAngle.TabIndex = 48;
            this.yAngle.Scroll += new System.EventHandler(this.yAngle_Scroll);
            // 
            // xAngle
            // 
            this.xAngle.Location = new System.Drawing.Point(19, 169);
            this.xAngle.Maximum = 360;
            this.xAngle.Name = "xAngle";
            this.xAngle.Size = new System.Drawing.Size(234, 56);
            this.xAngle.TabIndex = 47;
            this.xAngle.Value = 90;
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
            // labelZPos
            // 
            this.labelZPos.AutoSize = true;
            this.labelZPos.Location = new System.Drawing.Point(620, 89);
            this.labelZPos.Name = "labelZPos";
            this.labelZPos.Size = new System.Drawing.Size(16, 17);
            this.labelZPos.TabIndex = 64;
            this.labelZPos.Text = "0";
            // 
            // labelYPos
            // 
            this.labelYPos.AutoSize = true;
            this.labelYPos.Location = new System.Drawing.Point(384, 89);
            this.labelYPos.Name = "labelYPos";
            this.labelYPos.Size = new System.Drawing.Size(16, 17);
            this.labelYPos.TabIndex = 63;
            this.labelYPos.Text = "0";
            // 
            // labelXPos
            // 
            this.labelXPos.AutoSize = true;
            this.labelXPos.Location = new System.Drawing.Point(126, 89);
            this.labelXPos.Name = "labelXPos";
            this.labelXPos.Size = new System.Drawing.Size(16, 17);
            this.labelXPos.TabIndex = 62;
            this.labelXPos.Text = "0";
            // 
            // zPos
            // 
            this.zPos.Location = new System.Drawing.Point(513, 50);
            this.zPos.Maximum = 100;
            this.zPos.Minimum = -100;
            this.zPos.Name = "zPos";
            this.zPos.Size = new System.Drawing.Size(234, 56);
            this.zPos.TabIndex = 61;
            this.zPos.Scroll += new System.EventHandler(this.zPos_Scroll);
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(273, 50);
            this.yPos.Maximum = 100;
            this.yPos.Minimum = -100;
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(234, 56);
            this.yPos.TabIndex = 60;
            this.yPos.Scroll += new System.EventHandler(this.yPos_Scroll);
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(19, 50);
            this.xPos.Maximum = 100;
            this.xPos.Minimum = -100;
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(234, 56);
            this.xPos.TabIndex = 59;
            this.xPos.Scroll += new System.EventHandler(this.xPos_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Model Position (X,Y,Z):";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelZPos);
            this.Controls.Add(this.labelYPos);
            this.Controls.Add(this.labelXPos);
            this.Controls.Add(this.zPos);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xPos);
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
            ((System.ComponentModel.ISupportInitialize)(this.zPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos)).EndInit();
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
        private System.Windows.Forms.Label labelZPos;
        private System.Windows.Forms.Label labelYPos;
        private System.Windows.Forms.Label labelXPos;
        private System.Windows.Forms.TrackBar zPos;
        private System.Windows.Forms.TrackBar yPos;
        private System.Windows.Forms.TrackBar xPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}