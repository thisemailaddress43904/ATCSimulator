namespace ATC2027.Forms
{
    partial class AircraftCollectionRing
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
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            cmbBoxSelectAircraft = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            lblAltitude = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblSpeed = new System.Windows.Forms.Label();
            txtBoxHeading = new System.Windows.Forms.TextBox();
            txtBoxAltitude = new System.Windows.Forms.TextBox();
            txtBoxSpeed = new System.Windows.Forms.TextBox();
            btnApplyClearance = new System.Windows.Forms.Button();
            cmbBoxAltitudeType = new System.Windows.Forms.ComboBox();
            lblResult = new System.Windows.Forms.Label();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(cmbBoxSelectAircraft, 1, 3);
            tableLayoutPanel2.Controls.Add(label1, 3, 1);
            tableLayoutPanel2.Controls.Add(lblAltitude, 3, 3);
            tableLayoutPanel2.Controls.Add(label3, 3, 5);
            tableLayoutPanel2.Controls.Add(lblSpeed, 3, 7);
            tableLayoutPanel2.Controls.Add(txtBoxHeading, 4, 1);
            tableLayoutPanel2.Controls.Add(txtBoxAltitude, 4, 3);
            tableLayoutPanel2.Controls.Add(txtBoxSpeed, 4, 7);
            tableLayoutPanel2.Controls.Add(btnApplyClearance, 6, 3);
            tableLayoutPanel2.Controls.Add(cmbBoxAltitudeType, 4, 5);
            tableLayoutPanel2.Controls.Add(lblResult, 6, 6);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.65853667F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.097561F));
            tableLayoutPanel2.Size = new System.Drawing.Size(642, 242);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbBoxSelectAircraft
            // 
            cmbBoxSelectAircraft.FormattingEnabled = true;
            cmbBoxSelectAircraft.Location = new System.Drawing.Point(34, 68);
            cmbBoxSelectAircraft.Margin = new System.Windows.Forms.Padding(2);
            cmbBoxSelectAircraft.Name = "cmbBoxSelectAircraft";
            cmbBoxSelectAircraft.Size = new System.Drawing.Size(122, 28);
            cmbBoxSelectAircraft.TabIndex = 0;
            cmbBoxSelectAircraft.SelectedIndexChanged += cmbBoxSelectAircraft_SelectedIndexChanged;
            cmbBoxSelectAircraft.TextUpdate += cmbBoxSelectAircraft_TextUpdate;
            cmbBoxSelectAircraft.SelectedValueChanged += cmbBoxSelectAircraft_SelectedValueChanged;
            cmbBoxSelectAircraft.MouseEnter += cmbBoxSelectAircraft_MouseEnter_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(194, 14);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 44);
            label1.TabIndex = 1;
            label1.Text = "Heading";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAltitude.Location = new System.Drawing.Point(194, 66);
            lblAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new System.Drawing.Size(124, 44);
            lblAltitude.TabIndex = 2;
            lblAltitude.Text = "Altitude";
            lblAltitude.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(194, 118);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(124, 44);
            label3.TabIndex = 3;
            label3.Text = "AltitudeType";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            lblSpeed.Location = new System.Drawing.Point(194, 170);
            lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(124, 44);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxHeading
            // 
            txtBoxHeading.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxHeading.Location = new System.Drawing.Point(322, 16);
            txtBoxHeading.Margin = new System.Windows.Forms.Padding(2);
            txtBoxHeading.Name = "txtBoxHeading";
            txtBoxHeading.Size = new System.Drawing.Size(124, 27);
            txtBoxHeading.TabIndex = 5;
            // 
            // txtBoxAltitude
            // 
            txtBoxAltitude.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxAltitude.Location = new System.Drawing.Point(322, 68);
            txtBoxAltitude.Margin = new System.Windows.Forms.Padding(2);
            txtBoxAltitude.Name = "txtBoxAltitude";
            txtBoxAltitude.Size = new System.Drawing.Size(124, 27);
            txtBoxAltitude.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            txtBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBoxSpeed.Location = new System.Drawing.Point(322, 172);
            txtBoxSpeed.Margin = new System.Windows.Forms.Padding(2);
            txtBoxSpeed.Name = "txtBoxSpeed";
            txtBoxSpeed.Size = new System.Drawing.Size(124, 27);
            txtBoxSpeed.TabIndex = 8;
            // 
            // btnApplyClearance
            // 
            btnApplyClearance.Dock = System.Windows.Forms.DockStyle.Fill;
            btnApplyClearance.Location = new System.Drawing.Point(482, 68);
            btnApplyClearance.Margin = new System.Windows.Forms.Padding(2);
            btnApplyClearance.Name = "btnApplyClearance";
            btnApplyClearance.Size = new System.Drawing.Size(124, 40);
            btnApplyClearance.TabIndex = 9;
            btnApplyClearance.Text = "Apply Clearance";
            btnApplyClearance.UseVisualStyleBackColor = true;
            btnApplyClearance.Click += btnApplyClearance_Click;
            // 
            // cmbBoxAltitudeType
            // 
            cmbBoxAltitudeType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxAltitudeType.FormattingEnabled = true;
            cmbBoxAltitudeType.Location = new System.Drawing.Point(322, 120);
            cmbBoxAltitudeType.Margin = new System.Windows.Forms.Padding(2);
            cmbBoxAltitudeType.Name = "cmbBoxAltitudeType";
            cmbBoxAltitudeType.Size = new System.Drawing.Size(124, 28);
            cmbBoxAltitudeType.TabIndex = 10;
            // 
            // lblResult
            // 
            lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblResult.AutoSize = true;
            lblResult.ForeColor = System.Drawing.Color.Red;
            lblResult.Location = new System.Drawing.Point(482, 162);
            lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblResult.Name = "lblResult";
            tableLayoutPanel2.SetRowSpan(lblResult, 4);
            lblResult.Size = new System.Drawing.Size(124, 80);
            lblResult.TabIndex = 11;
            lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AircraftCollectionRing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(642, 242);
            Controls.Add(tableLayoutPanel2);
            Margin = new System.Windows.Forms.Padding(2);
            MaximumSize = new System.Drawing.Size(660, 289);
            MinimumSize = new System.Drawing.Size(660, 289);
            Name = "AircraftCollectionRing";
            Text = "AircraftCollectionRing";
            Load += AircraftCollectionRing_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbBoxSelectAircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtBoxHeading;
        private System.Windows.Forms.TextBox txtBoxAltitude;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.Button btnApplyClearance;
        private System.Windows.Forms.ComboBox cmbBoxAltitudeType;
        private System.Windows.Forms.Label lblResult;
    }
}