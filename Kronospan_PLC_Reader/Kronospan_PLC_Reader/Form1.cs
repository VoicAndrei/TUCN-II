using System;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;

namespace Kronospan_PLC_Reader
{
    public partial class Form1 : Form
    {
        private Plc plc;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();

        }

        private void InitializeComboBox()
        {
            comboBox_CPU_Type.Items.Add("S71500");
            comboBox_CPU_Type.Items.Add("S71200");
            comboBox_CPU_Type.SelectedIndex = 0;
            listView_DB_Locations.View = View.Details;
            listView_DB_Locations.FullRowSelect = true;
            listView_DB_Locations.Columns.Add("Name", listView_DB_Locations.Width - 20, HorizontalAlignment.Left);

            comboBox_DataType.Items.Add("Real");
            comboBox_DataType.Items.Add("Int");
            comboBox_DataType.SelectedIndex = 0;

        }

        private void button_Connect_PLC_Click(object sender, EventArgs e)
        {
            string cpuType = comboBox_CPU_Type.SelectedItem.ToString();
            string ipAddress = textBox_IP_Address.Text;
            int rack = int.Parse(textBox_Rack.Text);
            int slot = int.Parse(textBox_Slot.Text);

            plc = new Plc((CpuType)Enum.Parse(typeof(CpuType), cpuType), ipAddress, (short)rack, (short)slot);
            plc.Open();

            if (plc.IsConnected)
            {
                label_ConnectStatus.Text = "Connected";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Green;

                StartReadingPLC();
            }
            else
            {
                label_ConnectStatus.Text = "Not Connected";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button_Disconnect_PLC_Click(object sender, EventArgs e)
        {
            if (plc != null && plc.IsConnected)
            {
                StopReadingPLC();

                plc.Close();
                label_ConnectStatus.Text = "Disconnected";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void StartReadingPLC()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (plc != null && plc.IsConnected)
            {
                dataGridView_PLCValues.Rows.Clear();

                foreach (ListViewItem item in listView_DB_Locations.Items)
                {
                    int db = int.Parse(item.SubItems[1].Text);
                    int startByteAdr = int.Parse(item.SubItems[2].Text);
                    string dataType = item.SubItems[3].Text;

                    object valueRead;

                    switch (dataType)
                    {
                        case "Real":
                            valueRead = plc.Read(DataType.DataBlock, db, startByteAdr, VarType.Real, 1);
                            break;
                        case "Int":
                            valueRead = plc.Read(DataType.DataBlock, db, startByteAdr, VarType.Int, 1);
                            break;
                        case "Bool":
                            valueRead = plc.Read(DataType.DataBlock, db, startByteAdr, VarType.Bit, 1);
                            break;
                        // Add more cases for other data types if needed
                        default:
                            valueRead = null;
                            break;
                    }

                    if (valueRead != null)
                    {
                        dataGridView_PLCValues.Rows.Add(item.Text, $"DB{db}", $"{startByteAdr}", dataType, $"{valueRead}");
                    }
                    else
                    {
                        dataGridView_PLCValues.Rows.Add(item.Text, $"DB{db}", $"{startByteAdr}", dataType, "Error: Unable to read data");
                    }
                }
            }
        }




        private void button_Add_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_DB.Text, out int db) && int.TryParse(textBox_Location.Text, out int location) && !string.IsNullOrEmpty(textBox_Name.Text))
            {
                string name = textBox_Name.Text;
                string dataType = comboBox_DataType.SelectedItem.ToString();

                ListViewItem item = new ListViewItem($"{name}-{dataType}-DB{db}.{location}");
                item.SubItems.Add(db.ToString());
                item.SubItems.Add(location.ToString());
                item.SubItems.Add(dataType);
                listView_DB_Locations.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Please enter valid Name, DB, Location, and Data Type values.");
            }
        }




        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listView_DB_Locations.SelectedItems.Count > 0)
            {
                listView_DB_Locations.Items.Remove(listView_DB_Locations.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }









        private void StopReadingPLC()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
        }
    }
}
