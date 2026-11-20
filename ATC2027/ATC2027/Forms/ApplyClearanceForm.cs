using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.Clearance;
using ATC2027.ATC_Library.Clearance.AirfieldClearance;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Arrival;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Departure;
using ATC2027.ATC_Library.Clearance.AirfieldClearance.Interfaces;
using ATC2027.ATC_Library.Clearance.DirectControl;
using ATC2027.ATC_Library.Clearance.Interfaces;
using ATC2027.ATC_Library.Clearance.WaypointControl;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.Clearance;
using ATC2027.Clearance.DirectControl;
using ATC2027.Clearance.WaypointControl;
using ATC2027.Library.FlightNumber;
using SharpDX.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using Plane = ATC2027.ATC_Library.Plane.Plane;

namespace ATC2027.Forms
{
    public partial class ApplyClearanceForm : Form
    {
        IAirfield? airfield;
        CollectionRing collectionRing;
        public ApplyClearanceForm(ref CollectionRing collectionRing, ref IAirfield airfield)
        {
            this.airfield = airfield;
            this.collectionRing = collectionRing;
            InitializeComponent();
        }

        private void LoadSTARS_intoComboBox()
        {
            cmbBoxSTARCollection.Items.Clear();

            STAR[] starArr = airfield.GetSTARList().ToArray();

            foreach (STAR obj in starArr)
            {
                cmbBoxSTARCollection.Items.Add(obj.GetName());
            }


        }

        private void LoadSIDS_intoComboBox()
        {
            cmbBoxSidCollectionSelector.Items.Clear();

            SID[] sidArr = airfield.GetSIDList().ToArray();

            foreach (SID obj in sidArr)
                cmbBoxSidCollectionSelector.Items.Add(obj.getName());
        }

        private void ApplyClearanceForm_Load(object sender, EventArgs e)
        {
            acf_tc.TabIndex = 0;

            cmbBoxAltitudeType.Items.Clear();
            cmbBoxAltitudeType.Items.Add("Feet");
            cmbBoxAltitudeType.Items.Add("Flight Level");

            UpdateCmbBoxSelectAircraft();

            acf_tc_SelectedIndexChanged(sender, e);

            this.cmbBoxAirportSelectorDeparture.Items.Add(airfield.GetName());
            this.cmbBoxRunwaySelectorDeparture.Items.AddRange(airfield.getAllRunwayNames().ToArray());
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

                        LoadSTARS_intoComboBox();

                        break;
                    }
                case 2:
                    {
                        cmbBoxSidCollectionSelector.TabIndex = 1;
                        btnSidAddSID.TabIndex = 2;
                        listBoxSIDList.TabIndex = 3;
                        btnSidRemoveSID.TabIndex = 4;

                        LoadSIDS_intoComboBox();

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
            //Find the plane to apply the clearance to
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

            //get the selected index of the tab control
            int selectedIndex = acf_tc.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: //Direct Control
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
                            

                            //build the new clearance
                            ADirectControl clearance;
                            INonMutableClearance currentClearance = plane.getAirtimeClearance();

                            if (currentClearance == null)
                            {
                                clearance = MutableDirectControl.getEmptyClearance();
                            }
                            else if (currentClearance is ADirectControl)
                            {
                                clearance = new MutableDirectControl((ADirectControl)currentClearance);
                            }
                            else
                            {
                                clearance = MutableDirectControl.getEmptyClearance();
                            }


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
                                clearance.ApplyAltitude(Altitude.AltitudeFactory.build(txtBoxAltitude.Text, cmbBoxAltitudeType));

                            //apply clearance here
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
                case 1: //STAR Control
                    {
                        //check speed value is valid
                        Speed speed;
                        try
                        {
                             speed = new Speed(float.Parse(txtBoxStarSpeed.Text));
                        } catch (Exception ex)
                        {
                            if (txtBoxStarSpeed.Text == "")
                            {
                                speed = null;
                            } else
                            {
                                lblErrorLabel.Text = "Speed was not a number";
                                return;
                            }
                                

                            
                        }
                        Altitude altitude = Altitude.AltitudeFactory.build(txtBoxStarAltitudeValue.Text, cmboBoxStarAltitudeType);

                        NonMutableSTARClearance starClearance = NonMutableSTARClearanceFactory.Build(
                            (IList<string>)lbSTAR.Items,
                            this.airfield.GetSTARList(),
                            speed,
                            altitude);

                        this.collectionRing.ApplyClearance(starClearance, ref plane);

                        break;
                    }
                case 2:
                    {
                        //check speed value is valid
                        Speed speed;
                        try
                        {
                            speed = new Speed(float.Parse(txtBoxSidSpeed.Text));
                        }
                        catch (Exception ex)
                        {
                            if (txtBoxStarSpeed.Text == "")
                            {
                                speed = null;
                            }
                            else
                            {
                                lblErrorLabel.Text = "Speed was not a number";
                                return;
                            }


                            
                        }
                        Altitude altitude = Altitude.AltitudeFactory.build(txtBoxSidSpeed.Text, cmbBoxSidAltitudeType);


                        NonMutableSIDClearance sidCLearance = NonMutableSIDClearance.Factory.Build(listBoxSIDList.Items,this.airfield.GetSIDList(), speed, altitude);
                        
                        collectionRing.ApplyClearance(sidCLearance, ref plane);
                        break;
                    }
                case 3:
                    {
                        IRunway runway = airfield.getRunwayByName(cmbBoxRunwaySelectorArrival.Text);
                        string airfieldName = cmbBoxAirportSelectorArrival.Text;
                        FlightNumber flNo = new FlightNumber(cmbFlightNumbers.Text);
                        bool noDelay = false;

                        INonMutableArrivalClearance ac = new NonMutableArrivalClearance(runway, airfield, flNo, noDelay);

                        try
                        {
                            plane = collectionRing.GetPlaneByFlightNumber(cmbFlightNumbers.Text);
                            this.collectionRing.ApplyClearance(ac, ref plane);
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
                        break;
                    }
                case 4:
                    {
                        IRunway runway = airfield.getRunwayByName(cmbBoxRunwaySelectorArrival.Text);
                        string airfieldName = cmbBoxAirportSelectorDeparture.Text;
                        FlightNumber flNo = new FlightNumber(cmbFlightNumbers.Text);
                        bool noDelay = false;

                        INonMutableDepartureClearance dc = new NonMutableDepartureClearance(runway, airfieldName, flNo, noDelay);

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

        private void btnSidAddSID_Click(object sender, EventArgs e)
        {
            try
            {
                String nameOfSID = (string)cmbBoxSidCollectionSelector.Text;
                cmbBoxSidCollectionSelector.Items.RemoveAt(cmbBoxSidCollectionSelector.SelectedIndex);

                listBoxSIDList.Items.Add(nameOfSID);
            } catch (Exception ex)
            {
                
                return;
            }
            
        }

        private void btnSidRemoveSID_Click_1(object sender, EventArgs e)
        {
            String nameOfSID;
            try
            {
                nameOfSID = listBoxSIDList.SelectedItem.ToString();

                listBoxSIDList.Items.RemoveAt(listBoxSIDList.SelectedIndex);
                cmbBoxSidCollectionSelector.Items.Insert(0, nameOfSID);
            }
            catch (Exception ex)
            {
                //selected item was null
                return;
            }
            
            
        }

        private void btnAddSTAR_Click(object sender, EventArgs e)
        {
            String nameOfSTAR;
            try
            {
                nameOfSTAR = cmbBoxSTARCollection.Text;
                cmbBoxSTARCollection.Items.RemoveAt(cmbBoxSTARCollection.SelectedIndex);

                lbSTAR.Items.Add(nameOfSTAR);
            } catch (Exception ex)
            {
                //cmbBoxSTARCollection.Text was null
                return;
            }
            
            
        }

        private void btnRemoveSTAR_Click_1(object sender, EventArgs e)
        {
            String nameOfStar;

            try
            {
                nameOfStar = lbSTAR.SelectedItem?.ToString();

                lbSTAR.Items.RemoveAt(lbSTAR.SelectedIndex);
                cmbBoxSTARCollection.Items.Insert(0, nameOfStar);
            } catch(Exception ex)
            {
                //no item was selected
                return;
            }

            
            
        }
    }
}
