
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
            this.labelAngleZ = new System.Windows.Forms.Label();
            this.labelAngleY = new System.Windows.Forms.Label();
            this.labelAngleX = new System.Windows.Forms.Label();
            this.zAngle = new System.Windows.Forms.TrackBar();
            this.yAngle = new System.Windows.Forms.TrackBar();
            this.xAngle = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAngleZ
            // 
            this.labelAngleZ.AutoSize = true;
            this.labelAngleZ.Location = new System.Drawing.Point(620, 51);
            this.labelAngleZ.Name = "labelAngleZ";
            this.labelAngleZ.Size = new System.Drawing.Size(16, 17);
            this.labelAngleZ.TabIndex = 52;
            this.labelAngleZ.Text = "0";
            // 
            // labelAngleY
            // 
            this.labelAngleY.AutoSize = true;
            this.labelAngleY.Location = new System.Drawing.Point(384, 51);
            this.labelAngleY.Name = "labelAngleY";
            this.labelAngleY.Size = new System.Drawing.Size(16, 17);
            this.labelAngleY.TabIndex = 51;
            this.labelAngleY.Text = "0";
            // 
            // labelAngleX
            // 
            this.labelAngleX.AutoSize = true;
            this.labelAngleX.Location = new System.Drawing.Point(126, 51);
            this.labelAngleX.Name = "labelAngleX";
            this.labelAngleX.Size = new System.Drawing.Size(24, 17);
            this.labelAngleX.TabIndex = 50;
            this.labelAngleX.Text = "90";
            // 
            // zAngle
            // 
            this.zAngle.Location = new System.Drawing.Point(513, 12);
            this.zAngle.Maximum = 360;
            this.zAngle.Name = "zAngle";
            this.zAngle.Size = new System.Drawing.Size(234, 56);
            this.zAngle.TabIndex = 49;
            this.zAngle.Scroll += new System.EventHandler(this.zAngle_Scroll);
            // 
            // yAngle
            // 
            this.yAngle.Location = new System.Drawing.Point(273, 12);
            this.yAngle.Maximum = 360;
            this.yAngle.Name = "yAngle";
            this.yAngle.Size = new System.Drawing.Size(234, 56);
            this.yAngle.TabIndex = 48;
            this.yAngle.Scroll += new System.EventHandler(this.yAngle_Scroll);
            // 
            // xAngle
            // 
            this.xAngle.Location = new System.Drawing.Point(19, 12);
            this.xAngle.Maximum = 360;
            this.xAngle.Name = "xAngle";
            this.xAngle.Size = new System.Drawing.Size(234, 56);
            this.xAngle.TabIndex = 47;
            this.xAngle.Value = 90;
            this.xAngle.Scroll += new System.EventHandler(this.xAngle_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 53;
            this.button1.Text = "Read Form Sizes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAngleZ);
            this.Controls.Add(this.labelAngleY);
            this.Controls.Add(this.labelAngleX);
            this.Controls.Add(this.zAngle);
            this.Controls.Add(this.yAngle);
            this.Controls.Add(this.xAngle);
            this.Name = "Debug";
            this.Text = "Debug Panel";
            this.Load += new System.EventHandler(this.Debug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).EndInit();
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
    }
}