using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance.DirectControl;
using ATC2027.ExtensionClasses;
using ATC2027.Library.FlightNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC2027.Forms
{
    public partial class ApplyClearanceForm : Form
    {
        CollectionRing collectionRing;
        public ApplyClearanceForm(ref CollectionRing collectionRing)
        {
            this.collectionRing = collectionRing;

            InitializeComponent();
        }
        
        private void ApplyClearanceForm_Load(object sender, EventArgs e)
        {
            acf_tc.TabIndex = 0;

            cmbBoxAltitudeType.Items.Clear();
            cmbBoxAltitudeType.Items.Add("Feet");
            cmbBoxAltitudeType.Items.Add("Flight Level");

            UpdateCmbBoxSelectAircraft();

            acf_tc_SelectedIndexChanged(sender, e);
        }

        private void cmbFlightNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionRing.DeselectPlane();
            Plane selectedPlane = collectionRing.GetPlaneByFlightNumber(this.cmbFlightNumbers.Text);
            collectionRing.SelectPlane(ref selectedPlane);
        }

        private void acf_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (acf_tc.SelectedIndex)
            {
                case 0:
                    {
                        txtBoxHeading.TabIndex = 1;
                        txtBoxAltitude.TabIndex = 2;
                        cmbBoxAltitudeType.TabIndex = 3;
                        txtBoxSpeed.TabIndex = 4;

                        btnApplyClearance.TabIndex = 5;
                        break;
                    }
                case 1:
                    {
                        cmbBoxSTARCollection.TabIndex = 1;
                        btnAddSTAR.TabIndex = 2;
                        lbSTAR.TabIndex = 3;
                        btnRemoveSTAR.TabIndex = 4;

                        break;
                    }
                case 2:
                    {
                        cmbBoxSIDCollection.TabIndex = 1;
                        btnAddSID.TabIndex = 2;
                        lbSID.TabIndex = 3;
                        btnRemoveSID.TabIndex = 4;
                        break;
                    }
                case 3:
                    {
                        cmbBoxAirportSelectorArrival.TabIndex = 1;
                        cmbBoxRunwaySelectorArrival.TabIndex = 2;
                        btnApplyClearance.TabIndex = 3;
                        break;
                    }
                case 4:
                    {
                        cmbBoxAirportSelectorDeparture.TabIndex = 1;
                        cmbBoxRunwaySelectorDeparture.TabIndex = 2;
                        btnApplyClearance.TabIndex = 3;
                        break;
                    }
                default:
                    throw new NotImplementedException("TabIndex not yet handled");
            }
        }



        private void UpdateCmbBoxSelectAircraft()
        {
            int selectedTabIndex = acf_tc.SelectedIndex;

            //clear flight number combo box to prevent duplicate items being present when items are added again
            cmbFlightNumbers.Items.Clear();

            //populate planes with candidate planes to receive an instance of the selected indexes clearance type
            IList<Plane> planes;
            switch (selectedTabIndex)
            {
                case 0:
                    {
                        planes = collectionRing.getAircraftCollection().Where(x => x.CanBeConsideredForDirectClearance).ToList();
                        break;
                    }
                case 1:
                    {
                        planes = collectionRing.getAircraftCollection().Where(x => x.CanBeConsideredForSTARClearance).ToList();
                        break;
                    }
                case 2:
                    {
                        planes = collectionRing.getAircraftCollection().Where(x => x.CanBeConsideredForSIDClearance).ToList();
                        break;
                    }
                case 3:
                    {
                        planes = collectionRing.getAircraftCollection().Where(x => x.CanBeConsideredForLandingClearance).ToList();
                        break;
                    }
                case 4:
                    {
                        planes = collectionRing.getAircraftCollection().Where(x => x.CanBeConsideredForTakeoffClearance).ToList();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Selected tab index not handled", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        planes = [];
                        break;
                    }
            }
            //get the flight nunbers of the filtered in planes
            string[] flightNos = planes.Select(plane => plane.flightNoAsStr()).ToArray();
            //add the flight numbers to the empty combo box
            cmbFlightNumbers.Items.AddRange(flightNos);

        }

        private void btnApplyClearance_Click(object sender, EventArgs e)
        {
            //get the selected index of the tab control
            int selectedIndex = acf_tc.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    {
                        string errorMessage = "";

                        bool speedIsValid = Speed.SpeedIsValid(ref errorMessage, txtBoxSpeed.Text);
                        bool altitudeIsValid = Altitude.AltitudeIsValid(ref errorMessage, txtBoxAltitude.Text, Altitude.AltitudeTypeEnumFromString(cmbBoxAltitudeType.Text));
                        bool headingIsValid = Heading.HeadingIsValid(ref errorMessage, txtBoxHeading.Text);
                        bool flightNumberIsValid = FlightNumber.FlightNumberIsValid(ref errorMessage, cmbFlightNumbers.Text);

                        if (flightNumberIsValid)
                            flightNumberIsValid = cmbFlightNumbers.Items.Contains(cmbFlightNumbers.Text);

                        if (!(speedIsValid && altitudeIsValid && headingIsValid && flightNumberIsValid))
                        {
                            lblErrorLabel.Text = errorMessage;
                        }
                        else
                        {
                            ADirectControl clearance = MutableDirectControl.getEmptyClearance();

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
                                plane = collectionRing.GetPlaneByFlightNumber(cmbFlightNumbers.Text);
                            }
                            catch (Exception)
                            {

                                DialogResult result = MessageBox.Show(this, $"Unable to find {cmbFlightNumbers.Text}", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                                if (result == DialogResult.Cancel) { return; }
                                else if (result == DialogResult.Retry)
                                    btnApplyClearance_Click(this, new EventArgs());
                                else
                                {
                                    MessageBox.Show(this, $"Dialogue result {result} not handled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                return;
                            }

                            this.collectionRing.ApplyClearance(NonMutableClearanceFactory.BuildNonMutableControl(clearance), ref plane);

                            //clear text boxes and combo boxes
                            lblErrorLabel.Text = "clearance applied";
                            txtBoxAltitude.Text = "";
                            txtBoxHeading.Text = "";
                            txtBoxSpeed.Text = "";
                            cmbBoxAltitudeType.Text = "";
                            cmbFlightNumbers.Text = "";
                        }
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }

        }

        private void cmbFlightNumbers_MouseEnter(object sender, EventArgs e)
        {
            UpdateCmbBoxSelectAircraft();
        }

        private void cmbFlightNumbers_TextChanged(object sender, EventArgs e)
        {
            collectionRing.DeselectPlane();
            Plane selectedPlane = collectionRing.GetPlaneByFlightNumber(cmbFlightNumbers.Text);
            collectionRing.SelectPlane(ref selectedPlane);
        }
    }
}
