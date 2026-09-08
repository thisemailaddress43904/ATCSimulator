#pragma warning disable IDE1006 // Naming Styles

using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.Heading;
using ATC2027.DataStructures;
using ATC2027.Library.Altitude;
using ATC2027.Library.FlightNumber;
using ATC2027.Library.Speed;
using SharpDX.DirectWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class AircraftCollectionRing : Form
    {
        public bool formShouldBeUpdated = false;

        private readonly CollectionRing cr;
        
        
        public AircraftCollectionRing(ref CollectionRing cr)
        {
            this.cr = cr;

            InitializeComponent();

        }
        public void UpdateForm(object sender = null, EventArgs? e = null)
        {
        }

        private void UpdateDataGridViewOfSelectedTabIndex(object sender = null, EventArgs? e = null)
        {

        }


        private void btnApplyClearance_DragOver(object sender, DragEventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }
        private void btnApplyClearance_DragEnter(object sender, DragEventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void AircraftCollectionRing_Load(object sender, EventArgs e)
        {
            cmbBoxSelectAircraft.TabIndex = 0;
            txtBoxHeading.TabIndex = 1;
            txtBoxAltitude.TabIndex = 2;

            cmbBoxAltitudeType.TabIndex = 3;

            cmbBoxAltitudeType.Items.Clear();
            cmbBoxAltitudeType.Items.Add("Feet");
            cmbBoxAltitudeType.Items.Add("Flight Level");

            txtBoxSpeed.TabIndex = 4;
            btnApplyClearance.TabIndex = 5;

            UpdateCmbBoxSelectAircraft();
        }

        private void cmbBoxSelectAircraft_MouseEnter(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void txtBoxAltitude_TextChanged(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void cmbBoxAltitudeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do nothing here, function is being kept so the form doesn't break
        }

        private void btnApplyClearance_MouseHover(object sender, EventArgs e)
        {
        }

        private void cmbBoxSelectAircraft_MouseHover(object sender, EventArgs e)
        {
        }

        private void cmbBoxAltitudeType_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnApplyClearance_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            bool speedIsValid = Speed.SpeedIsValid(ref errorMessage, txtBoxSpeed.Text);
            bool altitudeIsValid = Altitude.AltitudeIsValid(ref errorMessage, txtBoxAltitude.Text, Altitude.AltitudeTypeEnumFromString(cmbBoxAltitudeType.Text));
            bool headingIsValid = Heading.HeadingIsValid(ref errorMessage, txtBoxHeading.Text);
            bool flightNumberIsValid = FlightNumber.FlightNumberIsValid(ref errorMessage, cmbBoxSelectAircraft.Text);

            if (flightNumberIsValid)
                flightNumberIsValid = cmbBoxSelectAircraft.Items.Contains(cmbBoxSelectAircraft.Text);

            if (!(speedIsValid && altitudeIsValid && headingIsValid && flightNumberIsValid))
            {
                lblResult.Text = errorMessage;
            }
            else
            {
                IClearance clearance = Clearance.getEmptyClearance();

                if (txtBoxHeading.Text != "")
                    clearance.ApplyHeading(new Heading(txtBoxHeading.Text));
                if (txtBoxSpeed.Text != "")
                {
                    float speedInKnots;
                    try
                    {
                        speedInKnots = int.Parse(txtBoxSpeed.Text);
                        clearance.ApplySpeed(new Speed(speedInKnots));
                    }
                    catch (Exception)
                    {
                        //this should never happen, validation is done by the function SpeedIsValid
                        MessageBox.Show(this, $"the given speed ({txtBoxSpeed.Text}) could not be converted to a float", "Error", MessageBoxButtons.OK);
                        txtBoxSpeed.Text = "";
                    }
                }
                if (txtBoxAltitude.Text != "")
                    clearance.ApplyAltitude(new Altitude(txtBoxAltitude.Text, cmbBoxAltitudeType));

                //apply clearance here
                Plane plane;
                try
                {
                    plane = cr.GetPlaneByFlightNumber(cmbBoxSelectAircraft.Text);
                }
                catch (Exception)
                {

                    DialogResult result = MessageBox.Show(this, $"Unable to find {cmbBoxSelectAircraft.Text}", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.Cancel) { return; }
                    else if (result == DialogResult.Retry)
                        btnApplyClearance_Click(this, new EventArgs());
                    else
                    {
                        MessageBox.Show(this, $"Dialogue result {result} not handled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                this.cr.ApplyClearance(clearance, ref plane);

                //clear text boxes and combo boxes
                lblResult.Text = "clearance applied";
                txtBoxAltitude.Text = "";
                txtBoxHeading.Text = "";
                txtBoxSpeed.Text = "";
                cmbBoxAltitudeType.Text = "";
                cmbBoxSelectAircraft.Text = "";

                cmbBoxSelectAircraft_SelectedValueChanged(sender, e);
            }
        }

        private void UpdateCmbBoxSelectAircraft()
        {
            cmbBoxSelectAircraft.Items.Clear();

            IList<Plane> planes = cr.getAircraftCollection();
            string[] flightNumbers = new string[planes.Count];

            for (int i = 0; i < planes.Count; i++)
            {
                flightNumbers[i] = planes[i].flightNoAsStr();
            }

            cmbBoxSelectAircraft.Items.AddRange(flightNumbers);
        }

        private void cmbBoxSelectAircraft_MouseEnter_1(object sender, EventArgs e)
        {
            UpdateCmbBoxSelectAircraft();
        }

        private void btnApplyClearance_Click_1(object sender, EventArgs e)
        {
        }

        private void cmbBoxSelectAircraft_SelectedValueChanged(object sender, EventArgs e)
        {
            cr.DeselectPlane();
            Plane selectedPlane = cr.GetPlaneByFlightNumber(cmbBoxSelectAircraft.Text);
            cr.SelectPlane(ref selectedPlane);
        }

        private void cmbBoxSelectAircraft_TextUpdate(object sender, EventArgs e)
        {
            cmbBoxSelectAircraft_SelectedValueChanged(sender, e);
        }
    }
}
