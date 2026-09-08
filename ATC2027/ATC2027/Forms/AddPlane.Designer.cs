namespace ATC2027.Forms
{
    partial class AddPlane
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblFlightNumber = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            lblSpeed = new System.Windows.Forms.Label();
            lblHeading = new System.Windows.Forms.Label();
            txtBoxFlightNumber = new System.Windows.Forms.TextBox();
            txtBoxAltitude = new System.Windows.Forms.TextBox();
            txtBoxSpeed = new System.Windows.Forms.TextBox();
            txtBoxHeading = new System.Windows.Forms.TextBox();
            btnAddPlane = new System.Windows.Forms.Button();
            lblAltitudeSuffix = new System.Windows.Forms.Label();
            lblSpeedSuffix = new System.Windows.Forms.Label();
            lblHeadingSuffix = new System.Windows.Forms.Label();
            lblSide = new System.Windows.Forms.Label();
            cmbBoxSelectSide = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            txtBoxAcrossSide = new System.Windows.Forms.TextBox();
            lblErrorLabel = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.94923F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8950462F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.15572F));
            tableLayoutPanel1.Controls.Add(lblFlightNumber, 0, 1);
            tableLayoutPanel1.Controls.Add(lblAltitude, 0, 2);
            tableLayoutPanel1.Controls.Add(lblSpeed, 0, 3);
            tableLayoutPanel1.Controls.Add(lblHeading, 0, 4);
            tableLayoutPanel1.Controls.Add(txtBoxFlightNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBoxAltitude, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBoxSpeed, 1, 3);
            tableLayoutPanel1.Controls.Add(txtBoxHeading, 1, 4);
            tableLayoutPanel1.Controls.Add(btnAddPlane, 1, 7);
            tableLayoutPanel1.Controls.Add(lblAltitudeSuffix, 2, 2);
            tableLayoutPanel1.Controls.Add(lblSpeedSuffix, 2, 3);
            tableLayoutPanel1.Controls.Add(lblHeadingSuffix, 2, 4);
            tableLayoutPanel1.Controls.Add(lblSide, 0, 5);
            tableLayoutPanel1.Controls.Add(cmbBoxSelectSide, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 6);
            tableLayoutPanel1.Controls.Add(txtBoxAcrossSide, 1, 6);
            tableLayoutPanel1.Controls.Add(lblErrorLabel, 0, 7);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.95049524F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3762379F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.8415842F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.95049524F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new System.Drawing.Size(306, 242);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Location = new System.Drawing.Point(37, 15);
            lblFlightNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new System.Drawing.Size(104, 20);
            lblFlightNumber.TabIndex = 0;
            lblFlightNumber.Text = "Flight Number";
            // 
            // lblAltitude
            // 
            lblAltitude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblAltitude.AutoSize = true;
            lblAltitude.Location = new System.Drawing.Point(79, 44);
            lblAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(62, 20);
            lblAltitude.TabIndex = 1;
            lblAltitude.Text = "Altitude";
            // 
            // lblSpeed
            // 
            lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new System.Drawing.Point(90, 73);
            lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(51, 20);
            lblSpeed.TabIndex = 2;
            lblSpeed.Text = "Speed";
            // 
            // lblHeading
            // 
            lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblHeading.AutoSize = true;
            lblHeading.Location = new System.Drawing.Point(75, 102);
            lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(66, 20);
            lblHeading.TabIndex = 3;
            lblHeading.Text = "Heading";
            // 
            // txtBoxFlightNumber
            // 
            txtBoxFlightNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxFlightNumber.Location = new System.Drawing.Point(145, 13);
            txtBoxFlightNumber.Margin = new System.Windows.Forms.Padding(2);
            txtBoxFlightNumber.Name = "txtBoxFlightNumber";
            txtBoxFlightNumber.Size = new System.Drawing.Size(104, 27);
            txtBoxFlightNumber.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxAltitude.Location = new System.Drawing.Point(145, 42);
            txtBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(104, 27);
            txtBoxAltitude.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxSpeed.Location = new System.Drawing.Point(145, 71);
            txtBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(104, 27);
            txtBoxSpeed.TabIndex = 7;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxHeading.Location = new System.Drawing.Point(145, 100);
            txtBoxHeading.Margin = new System.Windows.Forms.Padding(2);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(104, 27);
            txtBoxHeading.TabIndex = 8;
            // 
            // btnAddPlane
            // 
            btnAddPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAddPlane.Location = new System.Drawing.Point(145, 187);
            btnAddPlane.Margin = new System.Windows.Forms.Padding(2);
            btnAddPlane.Name = "btnAddPlane";
            btnAddPlane.Size = new System.Drawing.Size(105, 34);
            btnAddPlane.TabIndex = 4;
            btnAddPlane.Text = "Add Plane";
            btnAddPlane.UseVisualStyleBackColor = true;
            btnAddPlane.Click += btnAddPlane_Click;
            // 
            // lblAltitudeSuffix
            // 
            lblAltitudeSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAltitudeSuffix.AutoSize = true;
            lblAltitudeSuffix.Location = new System.Drawing.Point(254, 44);
            lblAltitudeSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitudeSuffix.Name = "lblAltitudeSuffix";
            lblAltitudeSuffix.Size = new System.Drawing.Size(19, 20);
            lblAltitudeSuffix.TabIndex = 9;
            lblAltitudeSuffix.Text = "ft";
            // 
            // lblSpeedSuffix
            // 
            lblSpeedSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblSpeedSuffix.AutoSize = true;
            lblSpeedSuffix.Location = new System.Drawing.Point(254, 73);
            lblSpeedSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeedSuffix.Name = "lblSpeedSuffix";
            lblSpeedSuffix.Size = new System.Drawing.Size(46, 20);
            lblSpeedSuffix.TabIndex = 10;
            lblSpeedSuffix.Text = "Knots";
            // 
            // lblHeadingSuffix
            // 
            lblHeadingSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblHeadingSuffix.AutoSize = true;
            lblHeadingSuffix.Location = new System.Drawing.Point(254, 102);
            lblHeadingSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHeadingSuffix.Name = "lblHeadingSuffix";
            lblHeadingSuffix.Size = new System.Drawing.Size(15, 20);
            lblHeadingSuffix.TabIndex = 11;
            lblHeadingSuffix.Text = "°";
            // 
            // lblSide
            // 
            lblSide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblSide.AutoSize = true;
            lblSide.Location = new System.Drawing.Point(59, 131);
            lblSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSide.Name = "lblSide";
            lblSide.Size = new System.Drawing.Size(82, 20);
            lblSide.TabIndex = 12;
            lblSide.Text = "Select Side";
            // 
            // cmbBoxSelectSide
            // 
            cmbBoxSelectSide.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbBoxSelectSide.FormattingEnabled = true;
            cmbBoxSelectSide.Location = new System.Drawing.Point(145, 129);
            cmbBoxSelectSide.Margin = new System.Windows.Forms.Padding(2);
            cmbBoxSelectSide.Name = "cmbBoxSelectSide";
            cmbBoxSelectSide.Size = new System.Drawing.Size(105, 28);
            cmbBoxSelectSide.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 160);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 20);
            label1.TabIndex = 14;
            label1.Text = "% Across Side";
            // 
            // txtBoxAcrossSide
            // 
            txtBoxAcrossSide.Location = new System.Drawing.Point(145, 158);
            txtBoxAcrossSide.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAcrossSide.Name = "txtBoxAcrossSide";
            txtBoxAcrossSide.Size = new System.Drawing.Size(104, 27);
            txtBoxAcrossSide.TabIndex = 15;
            // 
            // lblErrorLabel
            // 
            lblErrorLabel.AutoSize = true;
            lblErrorLabel.Location = new System.Drawing.Point(2, 185);
            lblErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblErrorLabel.Name = "lblErrorLabel";
            lblErrorLabel.Size = new System.Drawing.Size(0, 20);
            lblErrorLabel.TabIndex = 16;
            // 
            // AddPlane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(306, 242);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(324, 289);
            MinimumSize = new System.Drawing.Size(324, 289);
            Name = "AddPlane";
            Text = "Add Plane";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddPlane;
        private System.Windows.Forms.TextBox txtBoxFlightNumber;
        private System.Windows.Forms.TextBox txtBoxAltitude;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.TextBox txtBoxHeading;
        private System.Windows.Forms.Label lblAltitudeSuffix;
        private System.Windows.Forms.Label lblSpeedSuffix;
        private System.Windows.Forms.Label lblHeadingSuffix;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.ComboBox cmbBoxSelectSide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxAcrossSide;
        private System.Windows.Forms.Label lblErrorLabel;
    }
}