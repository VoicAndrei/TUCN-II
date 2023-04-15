namespace Kronospan_PLC_Reader
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
            this.timerReadPLC = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ConnectStatus = new System.Windows.Forms.Label();
            this.comboBox_CPU_Type = new System.Windows.Forms.ComboBox();
            this.button_Disconnect_PLC = new System.Windows.Forms.Button();
            this.button_Connect_PLC = new System.Windows.Forms.Button();
            this.textBox_Slot = new System.Windows.Forms.TextBox();
            this.textBox_Rack = new System.Windows.Forms.TextBox();
            this.textBox_IP_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_DataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.listView_DB_Locations = new System.Windows.Forms.ListView();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.textBox_DB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_PLCValues = new System.Windows.Forms.DataGridView();
            this.column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PLCValues)).BeginInit();
            this.SuspendLayout();
            // 
            // timerReadPLC
            // 
            this.timerReadPLC.Enabled = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ConnectStatus);
            this.groupBox1.Controls.Add(this.comboBox_CPU_Type);
            this.groupBox1.Controls.Add(this.button_Disconnect_PLC);
            this.groupBox1.Controls.Add(this.button_Connect_PLC);
            this.groupBox1.Controls.Add(this.textBox_Slot);
            this.groupBox1.Controls.Add(this.textBox_Rack);
            this.groupBox1.Controls.Add(this.textBox_IP_Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC Connection";
            // 
            // label_ConnectStatus
            // 
            this.label_ConnectStatus.AutoSize = true;
            this.label_ConnectStatus.Location = new System.Drawing.Point(15, 171);
            this.label_ConnectStatus.Name = "label_ConnectStatus";
            this.label_ConnectStatus.Size = new System.Drawing.Size(78, 13);
            this.label_ConnectStatus.TabIndex = 2;
            this.label_ConnectStatus.Text = "Not connected";
            // 
            // comboBox_CPU_Type
            // 
            this.comboBox_CPU_Type.FormattingEnabled = true;
            this.comboBox_CPU_Type.Location = new System.Drawing.Point(100, 38);
            this.comboBox_CPU_Type.Name = "comboBox_CPU_Type";
            this.comboBox_CPU_Type.Size = new System.Drawing.Size(177, 21);
            this.comboBox_CPU_Type.TabIndex = 9;
            // 
            // button_Disconnect_PLC
            // 
            this.button_Disconnect_PLC.Location = new System.Drawing.Point(202, 166);
            this.button_Disconnect_PLC.Name = "button_Disconnect_PLC";
            this.button_Disconnect_PLC.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect_PLC.TabIndex = 8;
            this.button_Disconnect_PLC.Text = "Disconnect";
            this.button_Disconnect_PLC.UseVisualStyleBackColor = true;
            this.button_Disconnect_PLC.Click += new System.EventHandler(this.button_Disconnect_PLC_Click);
            // 
            // button_Connect_PLC
            // 
            this.button_Connect_PLC.Location = new System.Drawing.Point(121, 166);
            this.button_Connect_PLC.Name = "button_Connect_PLC";
            this.button_Connect_PLC.Size = new System.Drawing.Size(75, 23);
            this.button_Connect_PLC.TabIndex = 7;
            this.button_Connect_PLC.Text = "Connect";
            this.button_Connect_PLC.UseVisualStyleBackColor = true;
            this.button_Connect_PLC.Click += new System.EventHandler(this.button_Connect_PLC_Click);
            // 
            // textBox_Slot
            // 
            this.textBox_Slot.Location = new System.Drawing.Point(100, 126);
            this.textBox_Slot.Name = "textBox_Slot";
            this.textBox_Slot.Size = new System.Drawing.Size(177, 20);
            this.textBox_Slot.TabIndex = 6;
            // 
            // textBox_Rack
            // 
            this.textBox_Rack.Location = new System.Drawing.Point(100, 97);
            this.textBox_Rack.Name = "textBox_Rack";
            this.textBox_Rack.Size = new System.Drawing.Size(177, 20);
            this.textBox_Rack.TabIndex = 5;
            // 
            // textBox_IP_Address
            // 
            this.textBox_IP_Address.Location = new System.Drawing.Point(100, 68);
            this.textBox_IP_Address.Name = "textBox_IP_Address";
            this.textBox_IP_Address.Size = new System.Drawing.Size(177, 20);
            this.textBox_IP_Address.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rack:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_DataType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Name);
            this.groupBox2.Controls.Add(this.listView_DB_Locations);
            this.groupBox2.Controls.Add(this.button_Remove);
            this.groupBox2.Controls.Add(this.button_Add);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Location);
            this.groupBox2.Controls.Add(this.textBox_DB);
            this.groupBox2.Location = new System.Drawing.Point(43, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Locations";
            // 
            // comboBox_DataType
            // 
            this.comboBox_DataType.FormattingEnabled = true;
            this.comboBox_DataType.Location = new System.Drawing.Point(68, 106);
            this.comboBox_DataType.Name = "comboBox_DataType";
            this.comboBox_DataType.Size = new System.Drawing.Size(100, 21);
            this.comboBox_DataType.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(68, 81);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 7;
            // 
            // listView_DB_Locations
            // 
            this.listView_DB_Locations.HideSelection = false;
            this.listView_DB_Locations.Location = new System.Drawing.Point(180, 31);
            this.listView_DB_Locations.Name = "listView_DB_Locations";
            this.listView_DB_Locations.Size = new System.Drawing.Size(110, 221);
            this.listView_DB_Locations.TabIndex = 6;
            this.listView_DB_Locations.UseCompatibleStateImageBehavior = false;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(93, 137);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(16, 137);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Offset:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "DB:";
            // 
            // textBox_Location
            // 
            this.textBox_Location.Location = new System.Drawing.Point(68, 56);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.Size = new System.Drawing.Size(100, 20);
            this.textBox_Location.TabIndex = 1;
            // 
            // textBox_DB
            // 
            this.textBox_DB.Location = new System.Drawing.Point(68, 31);
            this.textBox_DB.Name = "textBox_DB";
            this.textBox_DB.Size = new System.Drawing.Size(100, 20);
            this.textBox_DB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_PLCValues);
            this.groupBox3.Location = new System.Drawing.Point(398, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(721, 469);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Locations";
            // 
            // dataGridView_PLCValues
            // 
            this.dataGridView_PLCValues.AllowUserToAddRows = false;
            this.dataGridView_PLCValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PLCValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Name,
            this.column_DB,
            this.column_Offset,
            this.column_DataType,
            this.column_Value});
            this.dataGridView_PLCValues.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_PLCValues.Name = "dataGridView_PLCValues";
            this.dataGridView_PLCValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PLCValues.Size = new System.Drawing.Size(544, 450);
            this.dataGridView_PLCValues.TabIndex = 0;
            // 
            // column_Name
            // 
            this.column_Name.HeaderText = "Name";
            this.column_Name.Name = "column_Name";
            // 
            // column_DB
            // 
            this.column_DB.HeaderText = "DB";
            this.column_DB.Name = "column_DB";
            // 
            // column_Offset
            // 
            this.column_Offset.HeaderText = "Offset";
            this.column_Offset.Name = "column_Offset";
            // 
            // column_DataType
            // 
            this.column_DataType.HeaderText = "Data Type";
            this.column_DataType.Name = "column_DataType";
            // 
            // column_Value
            // 
            this.column_Value.HeaderText = "Value";
            this.column_Value.Name = "column_Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PLCValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerReadPLC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ConnectStatus;
        private System.Windows.Forms.ComboBox comboBox_CPU_Type;
        private System.Windows.Forms.Button button_Disconnect_PLC;
        private System.Windows.Forms.Button button_Connect_PLC;
        private System.Windows.Forms.TextBox textBox_Slot;
        private System.Windows.Forms.TextBox textBox_Rack;
        private System.Windows.Forms.TextBox textBox_IP_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_DB_Locations;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Location;
        private System.Windows.Forms.TextBox textBox_DB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_PLCValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_DataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DB;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Value;
    }
}

