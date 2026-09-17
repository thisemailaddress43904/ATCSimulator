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
            tpSID = new System.Windows.Forms.TabPage();
            tpArrival = new System.Windows.Forms.TabPage();
            tpDeparture = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tlpOuter.SuspendLayout();
            tlpInnerLeft.SuspendLayout();
            TabControl.SuspendLayout();
            tpArrival.SuspendLayout();
            tpDeparture.SuspendLayout();
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
            tpSTAR.Location = new System.Drawing.Point(4, 29);
            tpSTAR.Name = "tpSTAR";
            tpSTAR.Padding = new System.Windows.Forms.Padding(3);
            tpSTAR.Size = new System.Drawing.Size(676, 404);
            tpSTAR.TabIndex = 1;
            tpSTAR.Text = "STAR";
            // 
            // tpSID
            // 
            tpSID.BackColor = System.Drawing.Color.Silver;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
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
            tpArrival.ResumeLayout(false);
            tpDeparture.ResumeLayout(false);
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
    }
}