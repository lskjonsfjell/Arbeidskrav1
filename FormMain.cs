using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Arbeidskrav1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string recievedConfig = "C385IT001\n0.0\n500.0\n40\n440\n";
        string[] instrumentConfig;
        List<MeasurementPoint> allMeasuredPoints = new List<MeasurementPoint>();
        
        double chart1XValue = 0.0;
        double chart1YValue = 0.0;



        private void buttonDisconnect_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Disconnect";
        }

        private void buttonConnect_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Connect";
        }

        private void buttonSaveConfig2File_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Save to file";
        }

        private void tabPage_SerialPortConfig_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }



        private void tabPage_InstrumentConfig_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void tabControlMain_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void comboBox_ComPorts_Enter(object sender, EventArgs e)
        {
            comboBox_ComPorts.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBox_ComPorts.Items.Add(ports);

            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBox_ComPorts.SelectedIndex > -1)
            {
                serialPort1.PortName = comboBox_ComPorts.Items[comboBox_ComPorts.SelectedIndex].ToString();
                if (comboBox_BitRate.SelectedIndex > -1)
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_BitRate.Items[comboBox_BitRate.SelectedIndex]);
                    serialPort1.Open();
                    radioButtonConnected.Checked = true;
                    MessageBox.Show("Connection successful");

                }
            
                //FJERN!! TESTER PUSH 
                 else if (comboBox_ComPorts.SelectedIndex == 0 || comboBox_BitRate.SelectedIndex == 0)
                 {
                     MessageBox.Show("No connection established");
                 }
                 else if (comboBox_BitRate.SelectedIndex == 0)
                 {
                     MessageBox.Show("No connection established");
                 }


            }
          
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripStatusLabel1.Text = "Disconnected";
        }

        private void buttonSaveConfig2File_Click(object sender, EventArgs e)
        {


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string[] instrumentConfig = recievedConfig.Split(';');
                File.WriteAllText(saveFileDialog1.FileName, string.Join(";", instrumentConfig));

            }
        }

        private void timerChartadd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readanalog");
                timerSerialRecieve.Enabled = true;
                timerChartadd.Enabled = false;
            }
        }

        private void timerSerialRecieve_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {

                MeasurementPoint measuredPoint;
                string availableData = "";

                availableData += serialPort1.ReadExisting().ToString();

                string[] analogReadings = availableData.Split(';');

                textBoxReadFile.AppendText(availableData);

                if (analogReadings.Length == 4)
                {

                    //measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), Convert.ToInt32(analogReadings[0]), Convert.ToInt32(analogReadings[1]), Convert.ToInt32(analogReadings[2]));
                    //chart1.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.va);
                    //chart1.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.vb);
                    //chart1.Series[2].Points.AddXY(measuredPoint.time, measuredPoint.vba);
                    //allMeasuredPoints.Add(measuredPoint);



                    listBoxVa.Items.Add(analogReadings[0]);
                    chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxVa.Items.Count - 1),
                        Convert.ToDouble(listBoxVa.Items[listBoxVa.Items.Count - 1]));

                    listBoxVb.Items.Add(analogReadings[1]);
                    chart1.Series[1].Points.AddXY(Convert.ToDouble(listBoxVb.Items.Count - 1),
                        Convert.ToDouble(listBoxVb.Items[listBoxVb.Items.Count - 1]));

                    listBoxVba.Items.Add(analogReadings[2]);
                    chart1.Series[2].Points.AddXY(Convert.ToDouble(listBoxVba.Items.Count - 1),
                        Convert.ToDouble(listBoxVba.Items[listBoxVba.Items.Count - 1]));

                }
                timerChartadd.Enabled = true;
                timerSerialRecieve.Enabled = false;
            }
        }

        private void buttonStartAuto_Click(object sender, EventArgs e)
        {
            if (comboBox_ComPorts.SelectedIndex > -1)
            {
                timerChartadd.Enabled = true;
                toolStripStatusLabel1.Text = "Reading data from device";
            }
                
        }

        private void buttonStopAuto_Click(object sender, EventArgs e)
        {
            if (comboBox_ComPorts.SelectedIndex > -1)
            {
                timerChartadd.Enabled = false;
                timerSerialRecieve.Enabled = false;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                toolStripStatusLabel1.Text = "";
            }
              
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            string[] instrumentConfig = recievedConfig.Split(';');

            textBoxTagName.Text = instrumentConfig[0];
            textBoxLRV.Text = instrumentConfig[1];
            textBoxURV.Text = instrumentConfig[2];
            textBoxAlarmLow.Text = instrumentConfig[3];
            textBoxAlarmHigh.Text = instrumentConfig[4];
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < instrumentConfig.Length; i++)
            {
                if (instrumentConfig[i].Length > 0)
                {
                    switch (i)
                    {
                        case 0:
                            instrumentConfig[i] = textBoxTagName.Text;
                            break;
                        case 1:
                            instrumentConfig[i] = textBoxLRV.Text;
                            break;
                        case 2:
                            instrumentConfig[i] = textBoxURV.Text;
                            break;
                        case 3:
                            instrumentConfig[i] = textBoxAlarmLow.Text;
                            break;
                        case 4:
                            instrumentConfig[i] = textBoxAlarmHigh.Text;
                            break;
                        default:
                            break;
                    }

                    MessageBox.Show("Configuration empty");
                }
            }
        }

        private void buttonSaveCsv_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogCsv.FileName))

                    foreach (MeasurementPoint point in allMeasuredPoints)
                    {
                        streamWritePoints.WriteLine(point.ToString());
                    }
              
            }
        }

        public class MeasurementPoint
        {
            public string time { get; set; }
            public int va { get; set; }
            public int vb { get; set; }
            public int vba { get; set; }

            public MeasurementPoint(string time, int va, int vb, int vba)
            {
                this.time = time;
                this.va = va;
                this.vb = vb;
                this.vba = vba;

            }

            public override string ToString()
            {
                return time + ";" + va + ";" + vb + ";" + vba;
            }





        }
        public class Instrument
        {
            private int measurement;


            public Instrument(int measurement)
            {
                this.measurement = measurement;
            }

            public Instrument(string tagname, string unit, double lrv, double urv)
            {
                this.tagname = tagname;
                this.unit = unit;
                this.lrv = lrv;
                this.urv = urv;
            }
           
            public string tagname
            {
                get { return tagname; }
                set { tagname = value; }
            }
            public string unit { get; set; }
            public double lrv { get; set; }
            public double urv { get; set; }

            
            public double Scaled()
            {
                return measurement / 10.0;
            }

        }

   

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            var filename = string.Empty;

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files(*.txt)|.txt|All files (*.*|*.*";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filename = openFileDialog1.FileName;
                MessageBox.Show(filename);
            }
        }

       
        private void FormMain_Load(object sender, EventArgs e)
        {
            
            AboutBox1 popUp = new AboutBox1();
            popUp.ShowDialog(this);
        }
    }
}

    
