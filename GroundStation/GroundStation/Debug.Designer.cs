
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.TEAM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACKAGE_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESSURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTITUDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAT_VOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PITCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURN_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VID_SAVED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(986, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 53;
            this.button1.Text = "Read Form Sizes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // latData
            // 
            this.latData.Location = new System.Drawing.Point(1006, 301);
            this.latData.Name = "latData";
            this.latData.Size = new System.Drawing.Size(100, 22);
            this.latData.TabIndex = 54;
            // 
            // lngData
            // 
            this.lngData.Location = new System.Drawing.Point(1006, 329);
            this.lngData.Name = "lngData";
            this.lngData.Size = new System.Drawing.Size(100, 22);
            this.lngData.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(920, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Longitude:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 362);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Insert Packet (add only 1 row)";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEAM_ID,
            this.PACKAGE_NUM,
            this.PRESSURE,
            this.ALTITUDE,
            this.TEMP,
            this.BAT_VOL,
            this.STATUS,
            this.PITCH,
            this.ROLL,
            this.YAW,
            this.TURN_NUM,
            this.VID_SAVED});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Location = new System.Drawing.Point(13, 276);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.Size = new System.Drawing.Size(873, 95);
            this.dataGrid.TabIndex = 69;
            // 
            // TEAM_ID
            // 
            this.TEAM_ID.HeaderText = "TEAM ID";
            this.TEAM_ID.MinimumWidth = 6;
            this.TEAM_ID.Name = "TEAM_ID";
            // 
            // PACKAGE_NUM
            // 
            this.PACKAGE_NUM.HeaderText = "PACKAGE NUM";
            this.PACKAGE_NUM.MinimumWidth = 6;
            this.PACKAGE_NUM.Name = "PACKAGE_NUM";
            // 
            // PRESSURE
            // 
            this.PRESSURE.HeaderText = "PRESSURE";
            this.PRESSURE.MinimumWidth = 6;
            this.PRESSURE.Name = "PRESSURE";
            // 
            // ALTITUDE
            // 
            this.ALTITUDE.HeaderText = "ALTITUDE";
            this.ALTITUDE.MinimumWidth = 6;
            this.ALTITUDE.Name = "ALTITUDE";
            // 
            // TEMP
            // 
            this.TEMP.HeaderText = "TEMP";
            this.TEMP.MinimumWidth = 6;
            this.TEMP.Name = "TEMP";
            // 
            // BAT_VOL
            // 
            this.BAT_VOL.HeaderText = "BATTERY VOLTAGE";
            this.BAT_VOL.MinimumWidth = 6;
            this.BAT_VOL.Name = "BAT_VOL";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            // 
            // PITCH
            // 
            this.PITCH.HeaderText = "PITCH";
            this.PITCH.MinimumWidth = 6;
            this.PITCH.Name = "PITCH";
            // 
            // ROLL
            // 
            this.ROLL.HeaderText = "ROLL";
            this.ROLL.MinimumWidth = 6;
            this.ROLL.Name = "ROLL";
            // 
            // YAW
            // 
            this.YAW.HeaderText = "YAW";
            this.YAW.MinimumWidth = 6;
            this.YAW.Name = "YAW";
            // 
            // TURN_NUM
            // 
            this.TURN_NUM.HeaderText = "TURN NUM";
            this.TURN_NUM.MinimumWidth = 6;
            this.TURN_NUM.Name = "TURN_NUM";
            // 
            // VID_SAVED
            // 
            this.VID_SAVED.HeaderText = "VID SAVED";
            this.VID_SAVED.MinimumWidth = 6;
            this.VID_SAVED.Name = "VID_SAVED";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 49);
            this.button3.TabIndex = 70;
            this.button3.Text = "Insert Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 71;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 44);
            this.button5.TabIndex = 72;
            this.button5.Text = "Start Data Feeding";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(436, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 33);
            this.button6.TabIndex = 73;
            this.button6.Text = "Fake Connect";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1126, 490);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label4);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEAM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACKAGE_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESSURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTITUDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAT_VOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PITCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAW;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURN_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID_SAVED;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
    }
}