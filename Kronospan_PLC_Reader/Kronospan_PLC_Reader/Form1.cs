using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using S7.Net.Types;

namespace Kronospan_PLC_Reader
{


    public partial class Form1 : Form
    {
        private Plc plc;
        private List<PlcInfo> plcs = new List<PlcInfo>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeConnectedPLCsListView();

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

        private void InitializeConnectedPLCsListView()
        {
            listView_ConnectedPLCs.View = View.Details;
            listView_ConnectedPLCs.FullRowSelect = true;
            listView_ConnectedPLCs.Columns.Add("PLC Name", listView_ConnectedPLCs.Width / 2, HorizontalAlignment.Left);
            listView_ConnectedPLCs.Columns.Add("IP Address", listView_ConnectedPLCs.Width / 2, HorizontalAlignment.Left);
        }
        public class PlcInfo
        {
            public Plc PlcInstance { get; set; }
            public string PlcName { get; set; }
            public System.Windows.Forms.Timer Timer { get; set; }

            public PlcInfo(Plc plcInstance, string plcName, System.Windows.Forms.Timer timer)
            {
                PlcInstance = plcInstance;
                PlcName = plcName;
                Timer = timer;
            }
        }


        private void button_Connect_PLC_Click(object sender, EventArgs e)
        {
            string cpuType = comboBox_CPU_Type.SelectedItem.ToString();
            string ipAddress = textBox_IP_Address.Text;
            int rack = int.Parse(textBox_Rack.Text);
            int slot = int.Parse(textBox_Slot.Text);

            plc = new Plc((CpuType)Enum.Parse(typeof(CpuType), cpuType), ipAddress, (short)rack, (short)slot);
 
            try
            {
                plc.Open();
                if (plc.IsConnected)
            {
                label_ConnectStatus.Text = "Connected";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Green;

                string plcName = $"PLC {plcs.Count + 1}";

                System.Windows.Forms.Timer newTimer = new System.Windows.Forms.Timer();
                newTimer.Interval = 1000; // 1 second interval
                newTimer.Tick += (s, ev) => Timer_TickForPlc(plc, plcName);
                newTimer.Start();

                plcs.Add(new PlcInfo(plc, plcName, newTimer));

                ListViewItem item = new ListViewItem(plcName);
                item.SubItems.Add(ipAddress);
                listView_ConnectedPLCs.Items.Add(item);
            }
            else
            {
                label_ConnectStatus.Text = "Not Connected";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
            catch (Exception ex)
            {
                label_ConnectStatus.Text = "Error";
                label_ConnectStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Failed to connect to the PLC: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_TickForPlc(Plc plc, string plcName)
        {
            if (plc != null && plc.IsConnected)
            {
                foreach (ListViewItem item in listView_DB_Locations.Items)
                {
                    int db = int.Parse(item.SubItems[1].Text);
                    int startByteAdr = int.Parse(item.SubItems[2].Text);
                    string dataType = item.SubItems[3].Text;
                    VarType varType = (VarType)Enum.Parse(typeof(VarType), dataType);

                    object valueRead;

                    try
                    {
                        switch (dataType)
                        {
                            case "Real":
                                valueRead = plc.Read(DataType.DataBlock, db, startByteAdr, VarType.Real, 1);
                                break;
                            case "Int":
                                valueRead = plc.Read(DataType.DataBlock, db, startByteAdr, VarType.Int, 1);
                                break;
                            default:
                                valueRead = null;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        valueRead = null;
                        Console.WriteLine($"Error reading data from PLC: {ex.Message}");
                    }

                    // Get the name part from the item's text
                    string nameOnly = item.Text.Split('-')[0];

                    // Find the existing row with the same PLC name and address
                    int rowIndex = -1;
                    for (int i = 0; i < dataGridView_PLCValues.Rows.Count; i++)
                    {
                        if (dataGridView_PLCValues.Rows[i].Cells[0].Value.ToString() == plcName &&
                            dataGridView_PLCValues.Rows[i].Cells[2].Value.ToString() == $"DB{db}" &&
                            dataGridView_PLCValues.Rows[i].Cells[3].Value.ToString() == $"{startByteAdr}")
                        {
                            rowIndex = i;
                            break;
                        }
                    }

                    // If a row with the same PLC name and address is found, update the row
                    if (rowIndex != -1)
                    {
                        if (valueRead != null)
                        {
                            dataGridView_PLCValues.Rows[rowIndex].Cells[5].Value = $"{valueRead}";
                        }
                        else
                        {
                            dataGridView_PLCValues.Rows[rowIndex].Cells[5].Value = "Error: Unable to read data";
                        }
                    }
                    // If no row with the same PLC name and address is found, add a new row
                    else
                    {
                        if (valueRead != null)
                        {
                            dataGridView_PLCValues.Rows.Add(plcName, nameOnly, $"DB{db}", $"{startByteAdr}", dataType, $"{valueRead}");
                        }
                        else
                        {
                            dataGridView_PLCValues.Rows.Add(plcName, nameOnly, $"DB{db}", $"{startByteAdr}", dataType, "Error: Unable to read data");
                        }
                    }
                }
            }
        }






        private void button_Disconnect_Selected_PLC_Click(object sender, EventArgs e)
        {
            if (listView_ConnectedPLCs.SelectedItems.Count > 0)
            {
                string selectedPlcName = listView_ConnectedPLCs.SelectedItems[0].Text;
                PlcInfo selectedPlcInfo = plcs.Find(p => p.PlcName == selectedPlcName);

                if (selectedPlcInfo != null)
                {
                    if (selectedPlcInfo.PlcInstance.IsConnected)
                    {
                        // Stop and dispose of the timer associated with the disconnected PLC
                        selectedPlcInfo.Timer.Stop();
                        selectedPlcInfo.Timer.Dispose();

                        selectedPlcInfo.PlcInstance.Close();
                        plcs.Remove(selectedPlcInfo);
                        listView_ConnectedPLCs.Items.Remove(listView_ConnectedPLCs.SelectedItems[0]);

                        // Remove the rows in dataGridView_PLCValues associated with the disconnected PLC.
                        for (int i = dataGridView_PLCValues.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dataGridView_PLCValues.Rows[i].Cells[0].Value.ToString() == selectedPlcName)
                            {
                                dataGridView_PLCValues.Rows.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a PLC to disconnect.");
            }
        }






       




        private void UpdateDataGridView(string plcName, string itemName, string db, string startByteAdr, string dataType, string valueRead)
        {
            foreach (DataGridViewRow row in dataGridView_PLCValues.Rows)
            {
                if (row.Cells[0].Value.ToString() == plcName && row.Cells[1].Value.ToString() == itemName)
                {
                    row.Cells[5].Value = valueRead;
                    return;
                }
            }

            dataGridView_PLCValues.Rows.Add(plcName, itemName, db, startByteAdr, dataType, valueRead);
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
                ListViewItem selectedItem = listView_DB_Locations.SelectedItems[0];

                // Get the name part from the selectedItem's text
                string nameOnly = selectedItem.Text.Split('-')[0];

                // Remove related rows from dataGridView_PLCValues
                for (int i = dataGridView_PLCValues.Rows.Count - 1; i >= 0; i--)
                {
                    if (dataGridView_PLCValues.Rows[i].Cells[1].Value.ToString() == nameOnly)
                    {
                        dataGridView_PLCValues.Rows.RemoveAt(i);
                    }
                }

                // Remove the selected item from listView_DB_Locations
                listView_DB_Locations.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }






    }
}
