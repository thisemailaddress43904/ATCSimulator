using ATC2027.ATC_Library;
using ATC2027.ATC_Library.Airfield;
using ATC2027.ATC_Library.CollectionRing;
using ATC2027.ATC_Library.ControlAttribute.Altitude;
using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.ATC_Library.ControlAttribute.Speed;
using ATC2027.ATC_Library.Plane;
using ATC2027.Database;
using ATC2027.ExtensionClasses;
using ATC2027.Library.FlightNumber;
using Microsoft.Data.Sqlite;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static ATC2027.ATC_Library.ControlAttribute.Altitude.AltitudeType;
using Plane = ATC2027.ATC_Library.Plane.Plane;

namespace ATC2027.Forms
{
    public partial class AddPlane : Form
    {
        #region headingOfNewPlane
        /// <summary>
        /// must be placed here even so the CalculateScoreFromSpawnPoint function can access heading
        /// </summary>
        private IHeading heading;
        private ISpeed speedForCalculatingHowLongObjectWillBeOnScreenFor = new Speed(250);
        private int bufferSize = 10;
        #endregion

        private CollectionRing cr;
        private IAirfield airfield;

        public AddPlane(ref CollectionRing cr, ref IAirfield airfield)
        {
            this.cr = cr;
            this.airfield = airfield;

            InitializeComponent();


            this.txtBoxFlightNumber.Text = getNextFlightNumber();
            this.cmbBoxSelectSide.Items.AddRange(["top", "left", "bottom", "right"]);

            this.txtBoxFlightNumber.TabIndex = 0;
            this.txtBoxAltitude.TabIndex = 1;
            this.txtBoxSpeed.TabIndex = 2;
            this.txtBoxHeading.TabIndex = 3;
            this.cmbBoxSelectSide.TabIndex = 4;
            this.txtBoxAcrossSide.TabIndex = 5;
            this.btnAddPlane.TabIndex = 6;
        }

        private bool ValuesAreValid(out string errorMessage)
        {
            errorMessage = "";
            if (!FlightNumber.FlightNumberIsValid(ref errorMessage, txtBoxFlightNumber.Text))
                return false;
            if (!Altitude.AltitudeIsValid(ref errorMessage, txtBoxAltitude.Text, AltitudeTypeEnum.Feet))
                return false;
            if (!Speed.SpeedIsValid(ref errorMessage, txtBoxSpeed.Text))
                return false;
            if (!Heading.HeadingIsValid(ref errorMessage, txtBoxHeading.Text))
                return false;
            if (!cmbBoxSelectSide.Items.Contains(cmbBoxSelectSide.Text))
            {
                errorMessage = "Unable to find side that was selected";
                return false;
            }
            if (!MathExtension.IsANumberWithInRange(txtBoxAcrossSide.Text, 0f, 100f))
            {
                errorMessage = "% across side was out of range";
                return false;
            }

            return true;
        }

        private IList<string> flightNumberPrefixes = ["AA", "DL", "UA", "EK", "SQ", "BA", "AF", "QF", "EJ", "LH"];
        private string getNextFlightNumber()
        {
            var random = new Random();
            var stringPart = flightNumberPrefixes[random.Next(0, flightNumberPrefixes.Count)];
            var numberPart = random.Next(1000, 9999);

            var candidateFlightNumber = stringPart + numberPart;

            if (cr.planeCollection.ContainsKey(candidateFlightNumber))
                return getNextFlightNumber();
            else return candidateFlightNumber;
        }

        private Vector2 CalculateSpawnLocationOfPlane(string sideName, float proportionAcrossSide)
        {
            Vector2 spawnLocation;
            sideName = sideName.ToLower();

            switch (sideName)
            {
                case "top":
                    spawnLocation = new Vector2(MathExtension.Map(proportionAcrossSide, 0, Constants.getWidthOfScreen), -20);
                    break;
                case "bottom":
                    spawnLocation = new Vector2(MathExtension.Map(proportionAcrossSide, 0, Constants.getWidthOfScreen), 20 + Constants.getHeightOfScreen);
                    break;
                case "left":
                    spawnLocation = new Vector2(-20, MathExtension.Map(proportionAcrossSide, 0, Constants.getHeightOfScreen));
                    break;
                case "right":
                    spawnLocation = new Vector2(20 + Constants.getWidthOfScreen, MathExtension.Map(proportionAcrossSide, 0, Constants.getHeightOfScreen));
                    break;
                default:
                    throw new NotImplementedException("direction not yet handled");
            }

            return spawnLocation;


        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {

            string errorMessage;
            if (ValuesAreValid(out errorMessage))
            {
                var flNo = new FlightNumber(txtBoxFlightNumber.Text);
                var heading = new Heading(txtBoxHeading.Text);
                var altitude = new Altitude(int.Parse(txtBoxAltitude.Text));
                var speed = new Speed(int.Parse(txtBoxSpeed.Text));

                this.heading = heading;
                var location = CalculateSpawnLocationOfPlane(cmbBoxSelectSide.Text, (float.Parse(txtBoxAcrossSide.Text)));

                cr.AddPlane(new Plane(
                    flNo,
                    heading,
                    altitude,
                    speed,
                    location,
                    Constants.getSpriteBatch().GraphicsDevice,
                    true));

                txtBoxFlightNumber.Text = getNextFlightNumber();
                txtBoxAltitude.Text = "";
                txtBoxHeading.Text = "";
                txtBoxSpeed.Text = "";
                cmbBoxSelectSide.Text = "";
                txtBoxAcrossSide.Text = "";

                lblErrorLabel.Text = "";
            }
            else
            {
                lblErrorLabel.Text = errorMessage;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            //select random location
            Task<IList<string>> randomAirfieldNames = getListOfAirfieldNames();

            //generate random flight number
            FlightNumber flNo = new FlightNumber(this.getNextFlightNumber());

            //Get longitude and latitude of the departure airfield that the plane departed from 
            Vector2 longAndLatOfPlaneDepartureLocation = new Vector2();

            string randomAirfieldName = randomAirfieldNames.Result[random.Next(0, randomAirfieldNames.Result.Count - 1)];
            //The only way an SQLinjection attack could be caused is if the database is modified, as SQLite is being used, this is entirely possible
            SqliteDataReader sqliteDataReader = DatabaseConnectivity.databaseConnectivity.GetDataReader($"SELECT tblLocation.latitude, tblLocation.longitude FROM tblLocation WHERE tblLocation.location == '" + randomAirfieldName + "' LIMIT 1;");

            while (sqliteDataReader.Read())
            {
                longAndLatOfPlaneDepartureLocation = new Vector2(sqliteDataReader.GetFloat(0), sqliteDataReader.GetFloat(1));
            }

            //Get longitude and latitude of the departure airfield that the plane departed from 
            Vector2 longAndLatOfPlaneArrivalLocation = new Vector2();

            //The only way an SQLinjection attack could be caused is if the database is modified, as SQLite is being used, this is entirely possible
            sqliteDataReader = DatabaseConnectivity.databaseConnectivity.GetDataReader($"SELECT tblLocation.latitude, tblLocation.longitude FROM tblLocation WHERE tblLocation.location == '" + "London Heathrow" + "' LIMIT 1;");

            while (sqliteDataReader.Read())
            {
                longAndLatOfPlaneArrivalLocation = new Vector2(sqliteDataReader.GetFloat(0), sqliteDataReader.GetFloat(1));
            }

            float heightOfRightAngleTriangle = longAndLatOfPlaneDepartureLocation.Y - longAndLatOfPlaneArrivalLocation.Y;
            float widthOfRightAngleTriangle = longAndLatOfPlaneDepartureLocation.X - longAndLatOfPlaneArrivalLocation.X;

            Altitude altitude = new Altitude(500 * random.Next(7, 18));
            Speed speed = new Speed(5 * random.Next(45, 60));

            float proportionAcrossScreen = random.Next(0, 100);

            ScreenSide side = (ScreenSide)0;//random.Next(1,4);
            Vector2 location = CalculateSpawnLocationOfPlane(side.ToString(), proportionAcrossScreen);

            Heading heading = CalculateRandomHeading(ref random, side, location, proportionAcrossScreen);

            Plane plane = new Plane(flNo, heading, altitude, speed, location, Constants.getGraphicsDevice(), true);

            cr.AddPlane(plane);
        }

        private Heading CalculateRandomHeading(ref Random random, ScreenSide screenSide, Vector2 location, float proportionAcrossSide)
        {
            float lowerLimit = 0;
            float upperLimit = 0;

            if (proportionAcrossSide < 0.5f)
            {
                lowerLimit = 5;
                upperLimit = MathExtension.Map(proportionAcrossSide * 2, 0, MathExtension.Map(proportionAcrossSide * 2, 85, 275));
            }
            else
            {
                lowerLimit = MathExtension.Map((proportionAcrossSide - 0.5) * 2, 85, 355);
                upperLimit = 275;
            }

            if (lowerLimit > upperLimit)
            {
                var limit = lowerLimit;
                lowerLimit = upperLimit;
                upperLimit = limit;
            }

            Heading heading = new Heading(random.Next((int)lowerLimit, (int)upperLimit));

            return heading;
        }

        private string CalculateSideFromHeading(IHeading heading)
        {
            float degrees = heading.GetHeadingInFloatDegrees();
            degrees = degrees % 360;
            if (degrees >= 315 || degrees <= 45)
            {
                return "bottom";
            }
            else if (degrees >= 45 && degrees <= 135)
            {
                return "right";
            }
            else if (degrees >= 135 && degrees <= 225)
            {
                return "top";
            }
            else
            {
                return "left";
            }
        }

        private async Task<IList<String>> getListOfAirfieldNames()
        {
            string str = "SELECT tblLocation.location as location FROM tblLocation;";

            IList<string> strings = [];

            SqliteDataReader sqliteDataReader = DatabaseConnectivity.databaseConnectivity.GetDataReader(str);

            while (sqliteDataReader.Read())
            {
                strings.Add(sqliteDataReader.GetString(0));
            }

            return strings;
        }

        private void btnAddDeparture_Click(object sender, EventArgs e)
        {
            Vector2 spawnPoint = (Vector2)airfield.GetSpawnPointForDepartures("27L");


            Plane plane = new Plane(new FlightNumber(txtBoxFlightNumber.Text), airfield.getRunwayByName("27L").getHeading(), airfield.GetAltitude(), new Speed(0), spawnPoint, Constants.getGraphicsDevice(),false);
            this.cr.AddPlane(plane);
        }
    }
}
