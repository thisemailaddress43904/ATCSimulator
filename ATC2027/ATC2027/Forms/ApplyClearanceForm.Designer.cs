namespace ATC2027.Forms
{
    partial class ApplyClearanceForm
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
            tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            tlpInnerLeft = new System.Windows.Forms.TableLayoutPanel();
            cmbFlightNumbers = new System.Windows.Forms.ComboBox();
            btnApplyClearance = new System.Windows.Forms.Button();
            TabControl = new System.Windows.Forms.TabControl();
            tpDirectControl = new System.Windows.Forms.TabPage();
            tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblSpeed = new System.Windows.Forms.Label();
            txtBoxHeading = new System.Windows.Forms.TextBox();
            txtBoxAltitude = new System.Windows.Forms.TextBox();
            txtBoxSpeed = new System.Windows.Forms.TextBox();
            cmbBoxAltitudeType = new System.Windows.Forms.ComboBox();
            tpSTAR = new System.Windows.Forms.TabPage();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            listBox1 = new System.Windows.Forms.ListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnAddSTAR = new System.Windows.Forms.Button();
            btnRemoveSTAR = new System.Windows.Forms.Button();
            tpSID = new System.Windows.Forms.TabPage();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            listBox2 = new System.Windows.Forms.ListBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            tpArrival = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            lblWindSpeedLabel = new System.Windows.Forms.Label();
            lblWindDirectionLabel = new System.Windows.Forms.Label();
            lblWindSpeedValue = new System.Windows.Forms.Label();
            lblWindDirectionValue = new System.Windows.Forms.Label();
            tpDeparture = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            comboBox5 = new System.Windows.Forms.ComboBox();
            comboBox6 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tlpOuter.SuspendLayout();
            tlpInnerLeft.SuspendLayout();
            TabControl.SuspendLayout();
            tpDirectControl.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tpSTAR.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tpSID.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tpArrival.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tpDeparture.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tlpOuter
            // 
            tlpOuter.BackColor = System.Drawing.SystemColors.ControlDark;
            tlpOuter.ColumnCount = 5;
            tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpOuter.Controls.Add(tlpInnerLeft, 1, 1);
            tlpOuter.Controls.Add(TabControl, 3, 1);
            tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpOuter.Location = new System.Drawing.Point(0, 0);
            tlpOuter.Name = "tlpOuter";
            tlpOuter.RowCount = 3;
            tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tlpOuter.Size = new System.Drawing.Size(1062, 493);
            tlpOuter.TabIndex = 0;
            // 
            // tlpInnerLeft
            // 
            tlpInnerLeft.ColumnCount = 1;
            tlpInnerLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInnerLeft.Controls.Add(cmbFlightNumbers, 0, 1);
            tlpInnerLeft.Controls.Add(btnApplyClearance, 0, 3);
            tlpInnerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpInnerLeft.Location = new System.Drawing.Point(56, 27);
            tlpInnerLeft.Name = "tlpInnerLeft";
            tlpInnerLeft.RowCount = 5;
            tlpInnerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpInnerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpInnerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpInnerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpInnerLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpInnerLeft.Size = new System.Drawing.Size(206, 437);
            tlpInnerLeft.TabIndex = 0;
            // 
            // cmbFlightNumbers
            // 
            cmbFlightNumbers.BackColor = System.Drawing.Color.Silver;
            cmbFlightNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            cmbFlightNumbers.FormattingEnabled = true;
            cmbFlightNumbers.Location = new System.Drawing.Point(3, 90);
            cmbFlightNumbers.Name = "cmbFlightNumbers";
            cmbFlightNumbers.Size = new System.Drawing.Size(200, 28);
            cmbFlightNumbers.TabIndex = 0;
            cmbFlightNumbers.SelectedIndexChanged += cmbFlightNumbers_SelectedIndexChanged;
            // 
            // btnApplyClearance
            // 
            btnApplyClearance.Dock = System.Windows.Forms.DockStyle.Fill;
            btnApplyClearance.Location = new System.Drawing.Point(3, 264);
            btnApplyClearance.Name = "btnApplyClearance";
            btnApplyClearance.Size = new System.Drawing.Size(200, 81);
            btnApplyClearance.TabIndex = 3;
            btnApplyClearance.Text = "Apply Clearance";
            btnApplyClearance.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tpDirectControl);
            TabControl.Controls.Add(tpSTAR);
            TabControl.Controls.Add(tpSID);
            TabControl.Controls.Add(tpArrival);
            TabControl.Controls.Add(tpDeparture);
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.Location = new System.Drawing.Point(321, 27);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(684, 437);
            TabControl.TabIndex = 1;
            // 
            // tpDirectControl
            // 
            tpDirectControl.BackColor = System.Drawing.Color.Silver;
            tpDirectControl.Controls.Add(tableLayoutPanel9);
            tpDirectControl.Location = new System.Drawing.Point(4, 29);
            tpDirectControl.Name = "tpDirectControl";
            tpDirectControl.Padding = new System.Windows.Forms.Padding(3);
            tpDirectControl.Size = new System.Drawing.Size(676, 404);
            tpDirectControl.TabIndex = 0;
            tpDirectControl.Text = "Direct Control";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 5;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel9.Controls.Add(label5, 1, 1);
            tableLayoutPanel9.Controls.Add(lblAltitude, 1, 3);
            tableLayoutPanel9.Controls.Add(label6, 1, 5);
            tableLayoutPanel9.Controls.Add(lblSpeed, 1, 7);
            tableLayoutPanel9.Controls.Add(txtBoxHeading, 2, 1);
            tableLayoutPanel9.Controls.Add(txtBoxAltitude, 2, 3);
            tableLayoutPanel9.Controls.Add(txtBoxSpeed, 2, 7);
            tableLayoutPanel9.Controls.Add(cmbBoxAltitudeType, 2, 5);
            tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 10;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel9.Size = new System.Drawing.Size(670, 398);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(35, 24);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(130, 72);
            label5.TabIndex = 1;
            label5.Text = "Heading";
            label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAltitude.Location = new System.Drawing.Point(35, 110);
            lblAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(130, 72);
            lblAltitude.TabIndex = 2;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(35, 196);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(130, 72);
            label6.TabIndex = 3;
            label6.Text = "AltitudeType";
            label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSpeed.Location = new System.Drawing.Point(35, 282);
            lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(130, 72);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxHeading.Location = new System.Drawing.Point(169, 26);
            txtBoxHeading.Margin = new System.Windows.Forms.Padding(2);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(197, 27);
            txtBoxHeading.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxAltitude.Location = new System.Drawing.Point(169, 112);
            txtBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(197, 27);
            txtBoxAltitude.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxSpeed.Location = new System.Drawing.Point(169, 284);
            txtBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(197, 27);
            txtBoxSpeed.TabIndex = 8;
            // 
            // cmbBoxAltitudeType
            // 
            cmbBoxAltitudeType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxAltitudeType.FormattingEnabled = true;
            cmbBoxAltitudeType.Location = new System.Drawing.Point(169, 198);
            cmbBoxAltitudeType.Margin = new System.Windows.Forms.Padding(2);
            cmbBoxAltitudeType.Name = "cmbBoxAltitudeType";
            cmbBoxAltitudeType.Size = new System.Drawing.Size(197, 28);
            cmbBoxAltitudeType.TabIndex = 10;
            // 
            // tpSTAR
            // 
            tpSTAR.BackColor = System.Drawing.Color.Silver;
            tpSTAR.Controls.Add(tableLayoutPanel3);
            tpSTAR.Location = new System.Drawing.Point(4, 29);
            tpSTAR.Name = "tpSTAR";
            tpSTAR.Padding = new System.Windows.Forms.Padding(3);
            tpSTAR.Size = new System.Drawing.Size(676, 404);
            tpSTAR.TabIndex = 1;
            tpSTAR.Text = "STAR";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel3.Controls.Add(listBox1, 2, 1);
            tableLayoutPanel3.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new System.Drawing.Size(670, 398);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(371, 42);
            listBox1.Name = "listBox1";
            tableLayoutPanel3.SetRowSpan(listBox1, 3);
            listBox1.Size = new System.Drawing.Size(296, 191);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(3, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(295, 28);
            comboBox1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel4.Controls.Add(btnAddSTAR, 0, 0);
            tableLayoutPanel4.Controls.Add(btnRemoveSTAR, 2, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 121);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(295, 33);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // btnAddSTAR
            // 
            btnAddSTAR.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAddSTAR.Location = new System.Drawing.Point(3, 3);
            btnAddSTAR.Name = "btnAddSTAR";
            btnAddSTAR.Size = new System.Drawing.Size(112, 27);
            btnAddSTAR.TabIndex = 0;
            btnAddSTAR.Text = "Add";
            btnAddSTAR.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSTAR
            // 
            btnRemoveSTAR.Dock = System.Windows.Forms.DockStyle.Fill;
            btnRemoveSTAR.Location = new System.Drawing.Point(180, 3);
            btnRemoveSTAR.Name = "btnRemoveSTAR";
            btnRemoveSTAR.Size = new System.Drawing.Size(112, 27);
            btnRemoveSTAR.TabIndex = 1;
            btnRemoveSTAR.Text = "Remove";
            btnRemoveSTAR.UseVisualStyleBackColor = true;
            // 
            // tpSID
            // 
            tpSID.BackColor = System.Drawing.Color.Silver;
            tpSID.Controls.Add(tableLayoutPanel5);
            tpSID.Location = new System.Drawing.Point(4, 29);
            tpSID.Name = "tpSID";
            tpSID.Padding = new System.Windows.Forms.Padding(3);
            tpSID.Size = new System.Drawing.Size(676, 404);
            tpSID.TabIndex = 2;
            tpSID.Text = "SID";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel5.Controls.Add(listBox2, 2, 1);
            tableLayoutPanel5.Controls.Add(comboBox2, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel5.Size = new System.Drawing.Size(670, 398);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new System.Drawing.Point(371, 42);
            listBox2.Name = "listBox2";
            tableLayoutPanel5.SetRowSpan(listBox2, 3);
            listBox2.Size = new System.Drawing.Size(296, 191);
            listBox2.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(3, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(295, 28);
            comboBox2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel6.Controls.Add(button1, 0, 0);
            tableLayoutPanel6.Controls.Add(button2, 2, 0);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(3, 121);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new System.Drawing.Size(295, 33);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.Location = new System.Drawing.Point(3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 27);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.Location = new System.Drawing.Point(180, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 27);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // tpArrival
            // 
            tpArrival.BackColor = System.Drawing.Color.Silver;
            tpArrival.Controls.Add(tableLayoutPanel1);
            tpArrival.Location = new System.Drawing.Point(4, 29);
            tpArrival.Name = "tpArrival";
            tpArrival.Padding = new System.Windows.Forms.Padding(3);
            tpArrival.Size = new System.Drawing.Size(676, 404);
            tpArrival.TabIndex = 3;
            tpArrival.Text = "Arrival";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(comboBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBox4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new System.Drawing.Size(670, 398);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(3, 42);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(295, 28);
            comboBox3.TabIndex = 0;
            // 
            // comboBox4
            // 
            comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(3, 160);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(295, 28);
            comboBox4.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(lblWindSpeedLabel, 0, 0);
            tableLayoutPanel7.Controls.Add(lblWindDirectionLabel, 0, 1);
            tableLayoutPanel7.Controls.Add(lblWindSpeedValue, 1, 0);
            tableLayoutPanel7.Controls.Add(lblWindDirectionValue, 1, 1);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(371, 42);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel7, 2);
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new System.Drawing.Size(296, 112);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // lblWindSpeedLabel
            // 
            lblWindSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblWindSpeedLabel.AutoSize = true;
            lblWindSpeedLabel.Location = new System.Drawing.Point(3, 0);
            lblWindSpeedLabel.Name = "lblWindSpeedLabel";
            lblWindSpeedLabel.Size = new System.Drawing.Size(142, 56);
            lblWindSpeedLabel.TabIndex = 0;
            lblWindSpeedLabel.Text = "Wind Speed: ";
            lblWindSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWindDirectionLabel
            // 
            lblWindDirectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblWindDirectionLabel.AutoSize = true;
            lblWindDirectionLabel.Location = new System.Drawing.Point(3, 56);
            lblWindDirectionLabel.Name = "lblWindDirectionLabel";
            lblWindDirectionLabel.Size = new System.Drawing.Size(142, 56);
            lblWindDirectionLabel.TabIndex = 1;
            lblWindDirectionLabel.Text = "Wind Direction:";
            lblWindDirectionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWindSpeedValue
            // 
            lblWindSpeedValue.AutoSize = true;
            lblWindSpeedValue.Location = new System.Drawing.Point(151, 0);
            lblWindSpeedValue.Name = "lblWindSpeedValue";
            lblWindSpeedValue.Size = new System.Drawing.Size(36, 20);
            lblWindSpeedValue.TabIndex = 2;
            lblWindSpeedValue.Text = "Null";
            // 
            // lblWindDirectionValue
            // 
            lblWindDirectionValue.AutoSize = true;
            lblWindDirectionValue.Location = new System.Drawing.Point(151, 56);
            lblWindDirectionValue.Name = "lblWindDirectionValue";
            lblWindDirectionValue.Size = new System.Drawing.Size(36, 20);
            lblWindDirectionValue.TabIndex = 3;
            lblWindDirectionValue.Text = "Null";
            // 
            // tpDeparture
            // 
            tpDeparture.BackColor = System.Drawing.Color.Silver;
            tpDeparture.Controls.Add(tableLayoutPanel2);
            tpDeparture.Location = new System.Drawing.Point(4, 29);
            tpDeparture.Name = "tpDeparture";
            tpDeparture.Size = new System.Drawing.Size(676, 404);
            tpDeparture.TabIndex = 4;
            tpDeparture.Text = "Departure";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(comboBox5, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBox6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new System.Drawing.Size(676, 404);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // comboBox5
            // 
            comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new System.Drawing.Point(3, 43);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new System.Drawing.Size(298, 28);
            comboBox5.TabIndex = 0;
            // 
            // comboBox6
            // 
            comboBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new System.Drawing.Point(3, 163);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new System.Drawing.Size(298, 28);
            comboBox6.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label1, 0, 0);
            tableLayoutPanel8.Controls.Add(label2, 0, 1);
            tableLayoutPanel8.Controls.Add(label3, 1, 0);
            tableLayoutPanel8.Controls.Add(label4, 1, 1);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel8.Location = new System.Drawing.Point(374, 43);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel8, 2);
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new System.Drawing.Size(299, 114);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 57);
            label1.TabIndex = 0;
            label1.Text = "Wind Speed: ";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 57);
            label2.TabIndex = 1;
            label2.Text = "Wind Direction:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(152, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Null";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(152, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Null";
            // 
            // ApplyClearanceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1062, 493);
            Controls.Add(tlpOuter);
            MaximumSize = new System.Drawing.Size(1080, 540);
            MinimumSize = new System.Drawing.Size(1080, 540);
            Name = "ApplyClearanceForm";
            Text = "ApplyClearanceForm";
            Load += ApplyClearanceForm_Load;
            tlpOuter.ResumeLayout(false);
            tlpInnerLeft.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tpDirectControl.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tpSTAR.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tpSID.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tpArrival.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tpDeparture.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInnerLeft;
        private System.Windows.Forms.ComboBox cmbFlightNumbers;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tpDirectControl;
        private System.Windows.Forms.TabPage tpSTAR;
        private System.Windows.Forms.TabPage tpSID;
        private System.Windows.Forms.TabPage tpArrival;
        private System.Windows.Forms.TabPage tpDeparture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAddSTAR;
        private System.Windows.Forms.Button btnRemoveSTAR;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblWindSpeedLabel;
        private System.Windows.Forms.Label lblWindDirectionLabel;
        private System.Windows.Forms.Label lblWindSpeedValue;
        private System.Windows.Forms.Label lblWindDirectionValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtBoxHeading;
        private System.Windows.Forms.TextBox txtBoxAltitude;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.ComboBox cmbBoxAltitudeType;
        private System.Windows.Forms.Button btnApplyClearance;
    }
}