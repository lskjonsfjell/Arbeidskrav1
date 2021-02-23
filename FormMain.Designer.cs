
namespace Arbeidskrav1
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage_SerialPortConfig = new System.Windows.Forms.TabPage();
            this.radioButtonConnected = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BitRate = new System.Windows.Forms.ComboBox();
            this.comboBox_ComPorts = new System.Windows.Forms.ComboBox();
            this.tabPage_InstrumentConfig = new System.Windows.Forms.TabPage();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReadData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxAlarmLow = new System.Windows.Forms.TextBox();
            this.textBoxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textBoxTagName = new System.Windows.Forms.TextBox();
            this.buttonSaveConfig2File = new System.Windows.Forms.Button();
            this.tabPage_CurrentValues = new System.Windows.Forms.TabPage();
            this.buttonSaveCsv = new System.Windows.Forms.Button();
            this.buttonStopAuto = new System.Windows.Forms.Button();
            this.buttonStartAuto = new System.Windows.Forms.Button();
            this.textBoxReadFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxVb = new System.Windows.Forms.ListBox();
            this.listBoxVba = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerChartadd = new System.Windows.Forms.Timer(this.components);
            this.timerSerialRecieve = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogCsv = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPage_SerialPortConfig.SuspendLayout();
            this.tabPage_InstrumentConfig.SuspendLayout();
            this.tabPage_CurrentValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage_SerialPortConfig);
            this.tabControlMain.Controls.Add(this.tabPage_InstrumentConfig);
            this.tabControlMain.Controls.Add(this.tabPage_CurrentValues);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.MouseHover += new System.EventHandler(this.tabControlMain_MouseHover);
            // 
            // tabPage_SerialPortConfig
            // 
            this.tabPage_SerialPortConfig.Controls.Add(this.radioButtonConnected);
            this.tabPage_SerialPortConfig.Controls.Add(this.buttonConnect);
            this.tabPage_SerialPortConfig.Controls.Add(this.buttonDisconnect);
            this.tabPage_SerialPortConfig.Controls.Add(this.label2);
            this.tabPage_SerialPortConfig.Controls.Add(this.label1);
            this.tabPage_SerialPortConfig.Controls.Add(this.comboBox_BitRate);
            this.tabPage_SerialPortConfig.Controls.Add(this.comboBox_ComPorts);
            this.tabPage_SerialPortConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SerialPortConfig.Name = "tabPage_SerialPortConfig";
            this.tabPage_SerialPortConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SerialPortConfig.Size = new System.Drawing.Size(792, 424);
            this.tabPage_SerialPortConfig.TabIndex = 0;
            this.tabPage_SerialPortConfig.Text = "Serial Port Configuration";
            this.tabPage_SerialPortConfig.UseVisualStyleBackColor = true;
            this.tabPage_SerialPortConfig.MouseHover += new System.EventHandler(this.tabPage_SerialPortConfig_MouseHover);
            // 
            // radioButtonConnected
            // 
            this.radioButtonConnected.AutoSize = true;
            this.radioButtonConnected.Location = new System.Drawing.Point(57, 184);
            this.radioButtonConnected.Name = "radioButtonConnected";
            this.radioButtonConnected.Size = new System.Drawing.Size(14, 13);
            this.radioButtonConnected.TabIndex = 8;
            this.radioButtonConnected.TabStop = true;
            this.radioButtonConnected.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(77, 179);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 3;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseHover += new System.EventHandler(this.buttonConnect_MouseHover);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(221, 179);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            this.buttonDisconnect.MouseHover += new System.EventHandler(this.buttonDisconnect_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Com Ports";
            // 
            // comboBox_BitRate
            // 
            this.comboBox_BitRate.FormattingEnabled = true;
            this.comboBox_BitRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "76800",
            "153600"});
            this.comboBox_BitRate.Location = new System.Drawing.Point(99, 100);
            this.comboBox_BitRate.Name = "comboBox_BitRate";
            this.comboBox_BitRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BitRate.TabIndex = 1;
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Items.AddRange(new object[] {
            "COM3",
            "COM4",
            "COM7"});
            this.comboBox_ComPorts.Location = new System.Drawing.Point(99, 58);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ComPorts.TabIndex = 0;
            this.comboBox_ComPorts.Enter += new System.EventHandler(this.comboBox_ComPorts_Enter);
            // 
            // tabPage_InstrumentConfig
            // 
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonOpenFile);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonUpdate);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonReadData);
            this.tabPage_InstrumentConfig.Controls.Add(this.label7);
            this.tabPage_InstrumentConfig.Controls.Add(this.label6);
            this.tabPage_InstrumentConfig.Controls.Add(this.label5);
            this.tabPage_InstrumentConfig.Controls.Add(this.label4);
            this.tabPage_InstrumentConfig.Controls.Add(this.label3);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxLRV);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxURV);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxAlarmLow);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxAlarmHigh);
            this.tabPage_InstrumentConfig.Controls.Add(this.textBoxTagName);
            this.tabPage_InstrumentConfig.Controls.Add(this.buttonSaveConfig2File);
            this.tabPage_InstrumentConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPage_InstrumentConfig.Name = "tabPage_InstrumentConfig";
            this.tabPage_InstrumentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_InstrumentConfig.Size = new System.Drawing.Size(792, 424);
            this.tabPage_InstrumentConfig.TabIndex = 1;
            this.tabPage_InstrumentConfig.Text = "Instrument Configuration";
            this.tabPage_InstrumentConfig.UseVisualStyleBackColor = true;
            this.tabPage_InstrumentConfig.MouseHover += new System.EventHandler(this.tabPage_InstrumentConfig_MouseHover);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(147, 209);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 13;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(339, 209);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReadData
            // 
            this.buttonReadData.Location = new System.Drawing.Point(237, 210);
            this.buttonReadData.Name = "buttonReadData";
            this.buttonReadData.Size = new System.Drawing.Size(75, 23);
            this.buttonReadData.TabIndex = 11;
            this.buttonReadData.Text = "Read Data";
            this.buttonReadData.UseVisualStyleBackColor = true;
            this.buttonReadData.Click += new System.EventHandler(this.buttonReadData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Alarm high";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alarm low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Upper Range Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lower Range Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tagname";
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(237, 89);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(100, 20);
            this.textBoxLRV.TabIndex = 5;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(237, 115);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(100, 20);
            this.textBoxURV.TabIndex = 4;
            // 
            // textBoxAlarmLow
            // 
            this.textBoxAlarmLow.Location = new System.Drawing.Point(237, 141);
            this.textBoxAlarmLow.Name = "textBoxAlarmLow";
            this.textBoxAlarmLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmLow.TabIndex = 3;
            // 
            // textBoxAlarmHigh
            // 
            this.textBoxAlarmHigh.Location = new System.Drawing.Point(237, 167);
            this.textBoxAlarmHigh.Name = "textBoxAlarmHigh";
            this.textBoxAlarmHigh.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlarmHigh.TabIndex = 2;
            // 
            // textBoxTagName
            // 
            this.textBoxTagName.Location = new System.Drawing.Point(237, 63);
            this.textBoxTagName.Name = "textBoxTagName";
            this.textBoxTagName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTagName.TabIndex = 1;
            
            // 
            // buttonSaveConfig2File
            // 
            this.buttonSaveConfig2File.Location = new System.Drawing.Point(439, 209);
            this.buttonSaveConfig2File.Name = "buttonSaveConfig2File";
            this.buttonSaveConfig2File.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveConfig2File.TabIndex = 0;
            this.buttonSaveConfig2File.Text = "Save to file";
            this.buttonSaveConfig2File.UseVisualStyleBackColor = true;
            this.buttonSaveConfig2File.Click += new System.EventHandler(this.buttonSaveConfig2File_Click);
            this.buttonSaveConfig2File.MouseHover += new System.EventHandler(this.buttonSaveConfig2File_MouseHover);
            // 
            // tabPage_CurrentValues
            // 
            this.tabPage_CurrentValues.Controls.Add(this.buttonSaveCsv);
            this.tabPage_CurrentValues.Controls.Add(this.buttonStopAuto);
            this.tabPage_CurrentValues.Controls.Add(this.buttonStartAuto);
            this.tabPage_CurrentValues.Controls.Add(this.textBoxReadFile);
            this.tabPage_CurrentValues.Controls.Add(this.label10);
            this.tabPage_CurrentValues.Controls.Add(this.label9);
            this.tabPage_CurrentValues.Controls.Add(this.label8);
            this.tabPage_CurrentValues.Controls.Add(this.listBoxVb);
            this.tabPage_CurrentValues.Controls.Add(this.listBoxVba);
            this.tabPage_CurrentValues.Controls.Add(this.listBoxVa);
            this.tabPage_CurrentValues.Controls.Add(this.chart1);
            this.tabPage_CurrentValues.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CurrentValues.Name = "tabPage_CurrentValues";
            this.tabPage_CurrentValues.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CurrentValues.Size = new System.Drawing.Size(792, 424);
            this.tabPage_CurrentValues.TabIndex = 2;
            this.tabPage_CurrentValues.Text = "Current Values";
            this.tabPage_CurrentValues.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCsv
            // 
            this.buttonSaveCsv.Location = new System.Drawing.Point(626, 167);
            this.buttonSaveCsv.Name = "buttonSaveCsv";
            this.buttonSaveCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCsv.TabIndex = 10;
            this.buttonSaveCsv.Text = "Save";
            this.buttonSaveCsv.UseVisualStyleBackColor = true;
            this.buttonSaveCsv.Click += new System.EventHandler(this.buttonSaveCsv_Click);
            // 
            // buttonStopAuto
            // 
            this.buttonStopAuto.Location = new System.Drawing.Point(626, 138);
            this.buttonStopAuto.Name = "buttonStopAuto";
            this.buttonStopAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStopAuto.TabIndex = 9;
            this.buttonStopAuto.Text = "Stop";
            this.buttonStopAuto.UseVisualStyleBackColor = true;
            this.buttonStopAuto.Click += new System.EventHandler(this.buttonStopAuto_Click);
            // 
            // buttonStartAuto
            // 
            this.buttonStartAuto.Location = new System.Drawing.Point(626, 109);
            this.buttonStartAuto.Name = "buttonStartAuto";
            this.buttonStartAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonStartAuto.TabIndex = 8;
            this.buttonStartAuto.Text = "Start Auto";
            this.buttonStartAuto.UseVisualStyleBackColor = true;
            this.buttonStartAuto.Click += new System.EventHandler(this.buttonStartAuto_Click);
            // 
            // textBoxReadFile
            // 
            this.textBoxReadFile.Location = new System.Drawing.Point(195, 62);
            this.textBoxReadFile.Multiline = true;
            this.textBoxReadFile.Name = "textBoxReadFile";
            this.textBoxReadFile.Size = new System.Drawing.Size(100, 20);
            this.textBoxReadFile.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Vab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Vb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Va";
            // 
            // listBoxVb
            // 
            this.listBoxVb.FormattingEnabled = true;
            this.listBoxVb.Location = new System.Drawing.Point(101, 204);
            this.listBoxVb.Name = "listBoxVb";
            this.listBoxVb.Size = new System.Drawing.Size(46, 108);
            this.listBoxVb.TabIndex = 3;
            // 
            // listBoxVba
            // 
            this.listBoxVba.FormattingEnabled = true;
            this.listBoxVba.Location = new System.Drawing.Point(183, 204);
            this.listBoxVba.Name = "listBoxVba";
            this.listBoxVba.Size = new System.Drawing.Size(46, 108);
            this.listBoxVba.TabIndex = 2;
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.Location = new System.Drawing.Point(25, 204);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(46, 108);
            this.listBoxVa.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(332, 28);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Va";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Vb";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.MarkerSize = 10;
            series9.Name = "Vab";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(288, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ssc";
            // 
            // timerChartadd
            // 
            this.timerChartadd.Tick += new System.EventHandler(this.timerChartadd_Tick);
            // 
            // timerSerialRecieve
            // 
            this.timerSerialRecieve.Tick += new System.EventHandler(this.timerSerialRecieve_Tick);
            // 
            // saveFileDialogCsv
            // 
            this.saveFileDialogCsv.DefaultExt = "csv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "SoftSenseConf";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage_SerialPortConfig.ResumeLayout(false);
            this.tabPage_SerialPortConfig.PerformLayout();
            this.tabPage_InstrumentConfig.ResumeLayout(false);
            this.tabPage_InstrumentConfig.PerformLayout();
            this.tabPage_CurrentValues.ResumeLayout(false);
            this.tabPage_CurrentValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage_SerialPortConfig;
        private System.Windows.Forms.TabPage tabPage_InstrumentConfig;
        private System.Windows.Forms.TabPage tabPage_CurrentValues;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BitRate;
        private System.Windows.Forms.ComboBox comboBox_ComPorts;
        private System.Windows.Forms.Button buttonSaveConfig2File;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton radioButtonConnected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxAlarmLow;
        private System.Windows.Forms.TextBox textBoxAlarmHigh;
        private System.Windows.Forms.TextBox textBoxTagName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerChartadd;
        private System.Windows.Forms.Timer timerSerialRecieve;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxVb;
        private System.Windows.Forms.ListBox listBoxVba;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxReadFile;
        private System.Windows.Forms.Button buttonStopAuto;
        private System.Windows.Forms.Button buttonStartAuto;
        private System.Windows.Forms.Button buttonReadData;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCsv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSaveCsv;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}

