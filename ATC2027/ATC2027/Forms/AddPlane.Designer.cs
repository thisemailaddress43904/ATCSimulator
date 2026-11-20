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
            btnAddPlaneWithRandomAttributes = new System.Windows.Forms.Button();
            lblErrorLabel = new System.Windows.Forms.Label();
            btnAddDeparture = new System.Windows.Forms.Button();
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
            tableLayoutPanel1.Controls.Add(btnAddPlaneWithRandomAttributes, 0, 8);
            tableLayoutPanel1.Controls.Add(lblErrorLabel, 2, 7);
            tableLayoutPanel1.Controls.Add(btnAddDeparture, 0, 7);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.27337837F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.683445F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.6748095F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.6781979F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.27295065F));
            tableLayoutPanel1.Size = new System.Drawing.Size(270, 188);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblFlightNumber
            // 
            lblFlightNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblFlightNumber.AutoSize = true;
            lblFlightNumber.Location = new System.Drawing.Point(40, 10);
            lblFlightNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFlightNumber.Name = "lblFlightNumber";
            lblFlightNumber.Size = new System.Drawing.Size(84, 15);
            lblFlightNumber.TabIndex = 0;
            lblFlightNumber.Text = "Flight Number";
            // 
            // lblAltitude
            // 
            lblAltitude.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblAltitude.AutoSize = true;
            lblAltitude.Location = new System.Drawing.Point(75, 30);
            lblAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(49, 15);
            lblAltitude.TabIndex = 1;
            lblAltitude.Text = "Altitude";
            // 
            // lblSpeed
            // 
            lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new System.Drawing.Point(85, 50);
            lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(39, 15);
            lblSpeed.TabIndex = 2;
            lblSpeed.Text = "Speed";
            // 
            // lblHeading
            // 
            lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblHeading.AutoSize = true;
            lblHeading.Location = new System.Drawing.Point(72, 70);
            lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(52, 15);
            lblHeading.TabIndex = 3;
            lblHeading.Text = "Heading";
            // 
            // txtBoxFlightNumber
            // 
            txtBoxFlightNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxFlightNumber.Location = new System.Drawing.Point(128, 10);
            txtBoxFlightNumber.Margin = new System.Windows.Forms.Padding(2);
            txtBoxFlightNumber.Name = "txtBoxFlightNumber";
            txtBoxFlightNumber.Size = new System.Drawing.Size(92, 23);
            txtBoxFlightNumber.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxAltitude.Location = new System.Drawing.Point(128, 30);
            txtBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(92, 23);
            txtBoxAltitude.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxSpeed.Location = new System.Drawing.Point(128, 50);
            txtBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(92, 23);
            txtBoxSpeed.TabIndex = 7;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBoxHeading.Location = new System.Drawing.Point(128, 70);
            txtBoxHeading.Margin = new System.Windows.Forms.Padding(2);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(92, 23);
            txtBoxHeading.TabIndex = 8;
            // 
            // btnAddPlane
            // 
            btnAddPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAddPlane.Location = new System.Drawing.Point(128, 130);
            btnAddPlane.Margin = new System.Windows.Forms.Padding(2);
            btnAddPlane.Name = "btnAddPlane";
            btnAddPlane.Size = new System.Drawing.Size(92, 21);
            btnAddPlane.TabIndex = 4;
            btnAddPlane.Text = "Add Plane";
            btnAddPlane.UseVisualStyleBackColor = true;
            btnAddPlane.Click += btnAddPlane_Click;
            // 
            // lblAltitudeSuffix
            // 
            lblAltitudeSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAltitudeSuffix.AutoSize = true;
            lblAltitudeSuffix.Location = new System.Drawing.Point(224, 30);
            lblAltitudeSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitudeSuffix.Name = "lblAltitudeSuffix";
            lblAltitudeSuffix.Size = new System.Drawing.Size(15, 15);
            lblAltitudeSuffix.TabIndex = 9;
            lblAltitudeSuffix.Text = "ft";
            // 
            // lblSpeedSuffix
            // 
            lblSpeedSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblSpeedSuffix.AutoSize = true;
            lblSpeedSuffix.Location = new System.Drawing.Point(224, 50);
            lblSpeedSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeedSuffix.Name = "lblSpeedSuffix";
            lblSpeedSuffix.Size = new System.Drawing.Size(37, 15);
            lblSpeedSuffix.TabIndex = 10;
            lblSpeedSuffix.Text = "Knots";
            // 
            // lblHeadingSuffix
            // 
            lblHeadingSuffix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblHeadingSuffix.AutoSize = true;
            lblHeadingSuffix.Location = new System.Drawing.Point(224, 70);
            lblHeadingSuffix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHeadingSuffix.Name = "lblHeadingSuffix";
            lblHeadingSuffix.Size = new System.Drawing.Size(12, 15);
            lblHeadingSuffix.TabIndex = 11;
            lblHeadingSuffix.Text = "°";
            // 
            // lblSide
            // 
            lblSide.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblSide.AutoSize = true;
            lblSide.Location = new System.Drawing.Point(61, 90);
            lblSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSide.Name = "lblSide";
            lblSide.Size = new System.Drawing.Size(63, 15);
            lblSide.TabIndex = 12;
            lblSide.Text = "Select Side";
            // 
            // cmbBoxSelectSide
            // 
            cmbBoxSelectSide.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbBoxSelectSide.FormattingEnabled = true;
            cmbBoxSelectSide.Location = new System.Drawing.Point(128, 90);
            cmbBoxSelectSide.Margin = new System.Windows.Forms.Padding(2);
            cmbBoxSelectSide.Name = "cmbBoxSelectSide";
            cmbBoxSelectSide.Size = new System.Drawing.Size(92, 23);
            cmbBoxSelectSide.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 110);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 15);
            label1.TabIndex = 14;
            label1.Text = "% Across Side";
            // 
            // txtBoxAcrossSide
            // 
            txtBoxAcrossSide.Location = new System.Drawing.Point(128, 110);
            txtBoxAcrossSide.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAcrossSide.Name = "txtBoxAcrossSide";
            txtBoxAcrossSide.Size = new System.Drawing.Size(92, 23);
            txtBoxAcrossSide.TabIndex = 15;
            // 
            // btnAddPlaneWithRandomAttributes
            // 
            tableLayoutPanel1.SetColumnSpan(btnAddPlaneWithRandomAttributes, 2);
            btnAddPlaneWithRandomAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAddPlaneWithRandomAttributes.Location = new System.Drawing.Point(3, 156);
            btnAddPlaneWithRandomAttributes.Name = "btnAddPlaneWithRandomAttributes";
            tableLayoutPanel1.SetRowSpan(btnAddPlaneWithRandomAttributes, 2);
            btnAddPlaneWithRandomAttributes.Size = new System.Drawing.Size(216, 29);
            btnAddPlaneWithRandomAttributes.TabIndex = 17;
            btnAddPlaneWithRandomAttributes.Text = "AddPlaneWithRandomAttributes";
            btnAddPlaneWithRandomAttributes.UseVisualStyleBackColor = true;
            btnAddPlaneWithRandomAttributes.Click += button1_Click;
            // 
            // lblErrorLabel
            // 
            lblErrorLabel.AutoSize = true;
            lblErrorLabel.Location = new System.Drawing.Point(224, 128);
            lblErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblErrorLabel.Name = "lblErrorLabel";
            lblErrorLabel.Size = new System.Drawing.Size(0, 15);
            lblErrorLabel.TabIndex = 16;
            // 
            // btnAddDeparture
            // 
            btnAddDeparture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAddDeparture.Location = new System.Drawing.Point(3, 131);
            btnAddDeparture.Name = "btnAddDeparture";
            btnAddDeparture.Size = new System.Drawing.Size(120, 19);
            btnAddDeparture.TabIndex = 18;
            btnAddDeparture.Text = "Add Departure";
            btnAddDeparture.UseVisualStyleBackColor = true;
            btnAddDeparture.Click += btnAddDeparture_Click;
            // 
            // AddPlane
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(270, 188);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(286, 227);
            MinimumSize = new System.Drawing.Size(286, 227);
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
        private System.Windows.Forms.Button btnAddPlaneWithRandomAttributes;
        private System.Windows.Forms.Button btnAddDeparture;
    }
}