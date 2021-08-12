
namespace GroundStation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.active10SecBut = new System.Windows.Forms.Button();
            this.activeAlBut = new System.Windows.Forms.Button();
            this.releaseBut = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.TEAM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACKAGE_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME_SENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRESSURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTITUDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCENT_SPEED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAT_VOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPS_LAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPS_LON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPS_ALT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PITCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TURN_NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VID_SAVED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.slct_file = new System.Windows.Forms.Button();
            this.byteTrans = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.send_video = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portCombo = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.altGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tempGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.presGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.packGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.simulation_display = new System.Windows.Forms.Panel();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.camera_display = new System.Windows.Forms.Panel();
            this.selectVidButton = new System.Windows.Forms.Button();
            this.startVidButton = new System.Windows.Forms.Button();
            this.stopVidButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(505, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Available Ports:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Connection Status:";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.BackColor = System.Drawing.Color.Red;
            this.connectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectionLabel.Location = new System.Drawing.Point(214, 9);
            this.connectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(156, 25);
            this.connectionLabel.TabIndex = 20;
            this.connectionLabel.Text = "Not Connected";
            this.connectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // active10SecBut
            // 
            this.active10SecBut.Location = new System.Drawing.Point(265, 127);
            this.active10SecBut.Margin = new System.Windows.Forms.Padding(4);
            this.active10SecBut.Name = "active10SecBut";
            this.active10SecBut.Size = new System.Drawing.Size(224, 63);
            this.active10SecBut.TabIndex = 19;
            this.active10SecBut.Text = "Active for 10 Sec";
            this.active10SecBut.UseVisualStyleBackColor = true;
            // 
            // activeAlBut
            // 
            this.activeAlBut.Location = new System.Drawing.Point(265, 56);
            this.activeAlBut.Margin = new System.Windows.Forms.Padding(4);
            this.activeAlBut.Name = "activeAlBut";
            this.activeAlBut.Size = new System.Drawing.Size(224, 63);
            this.activeAlBut.TabIndex = 18;
            this.activeAlBut.Text = "Active Always";
            this.activeAlBut.UseVisualStyleBackColor = true;
            // 
            // releaseBut
            // 
            this.releaseBut.Location = new System.Drawing.Point(33, 127);
            this.releaseBut.Margin = new System.Windows.Forms.Padding(4);
            this.releaseBut.Name = "releaseBut";
            this.releaseBut.Size = new System.Drawing.Size(224, 63);
            this.releaseBut.TabIndex = 17;
            this.releaseBut.Text = "Send Release Command";
            this.releaseBut.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(33, 56);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 63);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start to Take";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
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
            this.TIME_SENT,
            this.PRESSURE,
            this.ALTITUDE,
            this.DESCENT_SPEED,
            this.TEMP,
            this.BAT_VOL,
            this.GPS_LAT,
            this.GPS_LON,
            this.GPS_ALT,
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
            this.dataGrid.Location = new System.Drawing.Point(13, 761);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
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
            this.dataGrid.Size = new System.Drawing.Size(1727, 219);
            this.dataGrid.TabIndex = 23;
            // 
            // TEAM_ID
            // 
            this.TEAM_ID.HeaderText = "TEAM ID";
            this.TEAM_ID.MinimumWidth = 6;
            this.TEAM_ID.Name = "TEAM_ID";
            this.TEAM_ID.ReadOnly = true;
            // 
            // PACKAGE_NUM
            // 
            this.PACKAGE_NUM.HeaderText = "PACKAGE NUM";
            this.PACKAGE_NUM.MinimumWidth = 6;
            this.PACKAGE_NUM.Name = "PACKAGE_NUM";
            this.PACKAGE_NUM.ReadOnly = true;
            // 
            // TIME_SENT
            // 
            this.TIME_SENT.HeaderText = "TIME SENT";
            this.TIME_SENT.MinimumWidth = 6;
            this.TIME_SENT.Name = "TIME_SENT";
            this.TIME_SENT.ReadOnly = true;
            // 
            // PRESSURE
            // 
            this.PRESSURE.HeaderText = "PRESSURE";
            this.PRESSURE.MinimumWidth = 6;
            this.PRESSURE.Name = "PRESSURE";
            this.PRESSURE.ReadOnly = true;
            // 
            // ALTITUDE
            // 
            this.ALTITUDE.HeaderText = "ALTITUDE";
            this.ALTITUDE.MinimumWidth = 6;
            this.ALTITUDE.Name = "ALTITUDE";
            this.ALTITUDE.ReadOnly = true;
            // 
            // DESCENT_SPEED
            // 
            this.DESCENT_SPEED.HeaderText = "DESCENT SPEED";
            this.DESCENT_SPEED.MinimumWidth = 6;
            this.DESCENT_SPEED.Name = "DESCENT_SPEED";
            this.DESCENT_SPEED.ReadOnly = true;
            // 
            // TEMP
            // 
            this.TEMP.HeaderText = "TEMP";
            this.TEMP.MinimumWidth = 6;
            this.TEMP.Name = "TEMP";
            this.TEMP.ReadOnly = true;
            // 
            // BAT_VOL
            // 
            this.BAT_VOL.HeaderText = "BATTERY VOLTAGE";
            this.BAT_VOL.MinimumWidth = 6;
            this.BAT_VOL.Name = "BAT_VOL";
            this.BAT_VOL.ReadOnly = true;
            // 
            // GPS_LAT
            // 
            this.GPS_LAT.HeaderText = "GPS LAT";
            this.GPS_LAT.MinimumWidth = 6;
            this.GPS_LAT.Name = "GPS_LAT";
            this.GPS_LAT.ReadOnly = true;
            // 
            // GPS_LON
            // 
            this.GPS_LON.HeaderText = "GPS LON";
            this.GPS_LON.MinimumWidth = 6;
            this.GPS_LON.Name = "GPS_LON";
            this.GPS_LON.ReadOnly = true;
            // 
            // GPS_ALT
            // 
            this.GPS_ALT.HeaderText = "GPS ALT";
            this.GPS_ALT.MinimumWidth = 6;
            this.GPS_ALT.Name = "GPS_ALT";
            this.GPS_ALT.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // PITCH
            // 
            this.PITCH.HeaderText = "PITCH";
            this.PITCH.MinimumWidth = 6;
            this.PITCH.Name = "PITCH";
            this.PITCH.ReadOnly = true;
            // 
            // ROLL
            // 
            this.ROLL.HeaderText = "ROLL";
            this.ROLL.MinimumWidth = 6;
            this.ROLL.Name = "ROLL";
            this.ROLL.ReadOnly = true;
            // 
            // YAW
            // 
            this.YAW.HeaderText = "YAW";
            this.YAW.MinimumWidth = 6;
            this.YAW.Name = "YAW";
            this.YAW.ReadOnly = true;
            // 
            // TURN_NUM
            // 
            this.TURN_NUM.HeaderText = "TURN NUM";
            this.TURN_NUM.MinimumWidth = 6;
            this.TURN_NUM.Name = "TURN_NUM";
            this.TURN_NUM.ReadOnly = true;
            // 
            // VID_SAVED
            // 
            this.VID_SAVED.HeaderText = "VID SAVED";
            this.VID_SAVED.MinimumWidth = 6;
            this.VID_SAVED.Name = "VID_SAVED";
            this.VID_SAVED.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1594, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 42);
            this.button3.TabIndex = 30;
            this.button3.Text = "Export Data";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // slct_file
            // 
            this.slct_file.Location = new System.Drawing.Point(963, 562);
            this.slct_file.Name = "slct_file";
            this.slct_file.Size = new System.Drawing.Size(146, 42);
            this.slct_file.TabIndex = 29;
            this.slct_file.Text = "Select File";
            this.slct_file.UseVisualStyleBackColor = true;
            this.slct_file.Click += new System.EventHandler(this.slct_file_Click);
            // 
            // byteTrans
            // 
            this.byteTrans.AutoSize = true;
            this.byteTrans.Location = new System.Drawing.Point(982, 692);
            this.byteTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.byteTrans.Name = "byteTrans";
            this.byteTrans.Size = new System.Drawing.Size(127, 17);
            this.byteTrans.TabIndex = 28;
            this.byteTrans.Text = "0 Byte Transferred";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // send_video
            // 
            this.send_video.Location = new System.Drawing.Point(926, 611);
            this.send_video.Margin = new System.Windows.Forms.Padding(4);
            this.send_video.Name = "send_video";
            this.send_video.Size = new System.Drawing.Size(224, 63);
            this.send_video.TabIndex = 26;
            this.send_video.Text = "Send Vid";
            this.send_video.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusLabel.Location = new System.Drawing.Point(1538, 9);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(97, 25);
            this.statusLabel.TabIndex = 25;
            this.statusLabel.Text = "Waiting..";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1356, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Satelleite Status:";
            // 
            // portCombo
            // 
            this.portCombo.FormattingEnabled = true;
            this.portCombo.Location = new System.Drawing.Point(671, 13);
            this.portCombo.Margin = new System.Windows.Forms.Padding(4);
            this.portCombo.Name = "portCombo";
            this.portCombo.Size = new System.Drawing.Size(192, 24);
            this.portCombo.TabIndex = 31;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Time (t)";
            chartArea1.AxisY.Title = "Voltage (V)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(608, 471);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Voltage Graph";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(273, 242);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            // 
            // altGraph
            // 
            chartArea2.AxisX.Title = "Time(t)";
            chartArea2.AxisY.Title = "Meeters (m)";
            chartArea2.Name = "ChartArea1";
            this.altGraph.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.altGraph.Legends.Add(legend2);
            this.altGraph.Location = new System.Drawing.Point(33, 471);
            this.altGraph.Margin = new System.Windows.Forms.Padding(4);
            this.altGraph.Name = "altGraph";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Altitude Graph";
            this.altGraph.Series.Add(series2);
            this.altGraph.Size = new System.Drawing.Size(283, 242);
            this.altGraph.TabIndex = 36;
            this.altGraph.Text = "altGraph";
            // 
            // tempGraph
            // 
            chartArea3.AxisX.Title = "Time (t)";
            chartArea3.AxisY.Title = "Celcius (C)";
            chartArea3.Name = "ChartArea1";
            this.tempGraph.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.tempGraph.Legends.Add(legend3);
            this.tempGraph.Location = new System.Drawing.Point(324, 471);
            this.tempGraph.Margin = new System.Windows.Forms.Padding(4);
            this.tempGraph.Name = "tempGraph";
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Orange;
            series3.Legend = "Legend1";
            series3.Name = "Temp Graph";
            this.tempGraph.Series.Add(series3);
            this.tempGraph.Size = new System.Drawing.Size(276, 242);
            this.tempGraph.TabIndex = 35;
            this.tempGraph.Text = "tempGraph";
            // 
            // presGraph
            // 
            chartArea4.AxisX.Title = "Time(t)";
            chartArea4.AxisY.Title = "Pascal (Pa)";
            chartArea4.Name = "ChartArea1";
            this.presGraph.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            this.presGraph.Legends.Add(legend4);
            this.presGraph.Location = new System.Drawing.Point(324, 211);
            this.presGraph.Margin = new System.Windows.Forms.Padding(4);
            this.presGraph.Name = "presGraph";
            series4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.Legend = "Legend1";
            series4.Name = "Pres Graph";
            this.presGraph.Series.Add(series4);
            this.presGraph.Size = new System.Drawing.Size(276, 252);
            this.presGraph.TabIndex = 34;
            this.presGraph.Text = "presGraph";
            // 
            // packGraph
            // 
            chartArea5.AxisX.Title = "Time(t)";
            chartArea5.AxisY.Title = "Package Number";
            chartArea5.Name = "ChartArea1";
            this.packGraph.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            this.packGraph.Legends.Add(legend5);
            this.packGraph.Location = new System.Drawing.Point(33, 211);
            this.packGraph.Margin = new System.Windows.Forms.Padding(4);
            this.packGraph.Name = "packGraph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Package Graph";
            this.packGraph.Series.Add(series5);
            this.packGraph.Size = new System.Drawing.Size(283, 252);
            this.packGraph.TabIndex = 33;
            this.packGraph.Text = "packGraph";
            // 
            // simulation_display
            // 
            this.simulation_display.BackColor = System.Drawing.SystemColors.Control;
            this.simulation_display.Location = new System.Drawing.Point(671, 73);
            this.simulation_display.Name = "simulation_display";
            this.simulation_display.Size = new System.Drawing.Size(455, 315);
            this.simulation_display.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Interval = 10900;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            // 
            // timer3
            // 
            this.timer3.Interval = 490;
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(1185, 394);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(484, 315);
            this.gMap.TabIndex = 39;
            this.gMap.Zoom = 13D;
            // 
            // camera_display
            // 
            this.camera_display.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.camera_display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camera_display.Location = new System.Drawing.Point(1185, 73);
            this.camera_display.Name = "camera_display";
            this.camera_display.Size = new System.Drawing.Size(484, 315);
            this.camera_display.TabIndex = 32;
            // 
            // selectVidButton
            // 
            this.selectVidButton.Location = new System.Drawing.Point(1317, 37);
            this.selectVidButton.Name = "selectVidButton";
            this.selectVidButton.Size = new System.Drawing.Size(126, 30);
            this.selectVidButton.TabIndex = 40;
            this.selectVidButton.Text = "Select File";
            this.selectVidButton.UseVisualStyleBackColor = true;
            this.selectVidButton.Click += new System.EventHandler(this.selectVidButton_Click);
            // 
            // startVidButton
            // 
            this.startVidButton.Location = new System.Drawing.Point(1185, 37);
            this.startVidButton.Name = "startVidButton";
            this.startVidButton.Size = new System.Drawing.Size(126, 30);
            this.startVidButton.TabIndex = 41;
            this.startVidButton.Text = "Start";
            this.startVidButton.UseVisualStyleBackColor = true;
            this.startVidButton.Click += new System.EventHandler(this.startVidButton_Click);
            // 
            // stopVidButton
            // 
            this.stopVidButton.Location = new System.Drawing.Point(1449, 37);
            this.stopVidButton.Name = "stopVidButton";
            this.stopVidButton.Size = new System.Drawing.Size(126, 30);
            this.stopVidButton.TabIndex = 42;
            this.stopVidButton.Text = "Stop";
            this.stopVidButton.UseVisualStyleBackColor = true;
            this.stopVidButton.Click += new System.EventHandler(this.stopVidButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1747, 993);
            this.Controls.Add(this.stopVidButton);
            this.Controls.Add(this.startVidButton);
            this.Controls.Add(this.selectVidButton);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.simulation_display);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.altGraph);
            this.Controls.Add(this.tempGraph);
            this.Controls.Add(this.presGraph);
            this.Controls.Add(this.packGraph);
            this.Controls.Add(this.camera_display);
            this.Controls.Add(this.portCombo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.slct_file);
            this.Controls.Add(this.byteTrans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send_video);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.active10SecBut);
            this.Controls.Add(this.activeAlBut);
            this.Controls.Add(this.releaseBut);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SwifTurk Ground Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Button active10SecBut;
        private System.Windows.Forms.Button activeAlBut;
        private System.Windows.Forms.Button releaseBut;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEAM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACKAGE_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME_SENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRESSURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTITUDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCENT_SPEED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAT_VOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPS_LAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPS_LON;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPS_ALT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PITCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAW;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURN_NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID_SAVED;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button slct_file;
        private System.Windows.Forms.Label byteTrans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button send_video;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portCombo;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.DataVisualization.Charting.Chart altGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart tempGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart presGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart packGraph;
        private System.Windows.Forms.Panel simulation_display;
        public System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Panel camera_display;
        private System.Windows.Forms.Button selectVidButton;
        private System.Windows.Forms.Button startVidButton;
        private System.Windows.Forms.Button stopVidButton;
    }
}