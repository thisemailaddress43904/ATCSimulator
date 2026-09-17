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
            TabControl = new System.Windows.Forms.TabControl();
            tpDirectControl = new System.Windows.Forms.TabPage();
            tpSTAR = new System.Windows.Forms.TabPage();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            listBox1 = new System.Windows.Forms.ListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnAddSTAR = new System.Windows.Forms.Button();
            btnRemoveSTAR = new System.Windows.Forms.Button();
            tpSID = new System.Windows.Forms.TabPage();
            tpArrival = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tpDeparture = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            comboBox2 = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            listBox2 = new System.Windows.Forms.ListBox();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            btnApply = new System.Windows.Forms.Button();
            tlpOuter.SuspendLayout();
            tlpInnerLeft.SuspendLayout();
            TabControl.SuspendLayout();
            tpSTAR.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tpSID.SuspendLayout();
            tpArrival.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tpDeparture.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
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
            tpDirectControl.Location = new System.Drawing.Point(4, 29);
            tpDirectControl.Name = "tpDirectControl";
            tpDirectControl.Padding = new System.Windows.Forms.Padding(3);
            tpDirectControl.Size = new System.Drawing.Size(676, 404);
            tpDirectControl.TabIndex = 0;
            tpDirectControl.Text = "Direct Control";
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
            tableLayoutPanel1.Controls.Add(btnApply, 2, 3);
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
            // comboBox2
            // 
            comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(3, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(295, 28);
            comboBox2.TabIndex = 1;
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
            // btnApply
            // 
            btnApply.Location = new System.Drawing.Point(371, 160);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(94, 29);
            btnApply.TabIndex = 2;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
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
            tpSTAR.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tpSID.ResumeLayout(false);
            tpArrival.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tpDeparture.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.Button btnApply;
    }
}