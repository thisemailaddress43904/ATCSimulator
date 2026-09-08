using ATC2027.ExtensionClasses;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATC2027.Library.Altitude
{
    public class Altitude : IAltitude
    {
        private float feet;
        private bool hasChanged;
        private string memoizedToString;

        public Altitude(float feet)
        {
            this.feet = feet;
            this.hasChanged = true;
            memoizedToString = ToString();
            this.hasChanged = false;
        }

        public Altitude(string text, System.Windows.Forms.ComboBox cmbBoxAltitudeType)
        {
            if (cmbBoxAltitudeType.Text.ToLower() == "feet")
                this.feet = int.Parse(text);
            else
                this.feet = float.Parse(text) * 1000;
        }

        public int GetAltitudeInFeet()
        {
            return (int)(feet);
        }

        public string GetAltitudeAsFlightLevel(int numberOfDigitsAfterTheDecimalPoint = 0)
        {
            float altitudeInFeet = GetAltitudeInFeet();
            float altitudeAsFlightLevel = altitudeInFeet / 1000;

            string altitudeAsFlightLevelAsString = altitudeInFeet.ToString();

            string[] split = altitudeAsFlightLevel.ToString().Split('.');
            bool altitudeAsFlightLevelHasDigitsAfterDecimalPoint = split.Length == 2;

            if (altitudeAsFlightLevelHasDigitsAfterDecimalPoint)
            {
                int noOfShifts = 0;
                while (noOfShifts < numberOfDigitsAfterTheDecimalPoint)
                {
                    altitudeAsFlightLevel *= 10;
                    noOfShifts++;
                }
                float a = (float)Math.Truncate((double)altitudeAsFlightLevel);
                while (noOfShifts > 0)
                {
                    altitudeAsFlightLevel /= 10;
                    noOfShifts--;
                }
                altitudeAsFlightLevelAsString = altitudeAsFlightLevel.ToString();
                altitudeAsFlightLevelAsString = StringExtension.GetFirstXCharactersFromString(ref altitudeAsFlightLevelAsString, numberOfDigitsAfterTheDecimalPoint == 0 ? 1 : 2 + numberOfDigitsAfterTheDecimalPoint);

            }
            else
            {
                return altitudeAsFlightLevel.ToString();
            }
            return altitudeAsFlightLevelAsString;

        }
        public string ToString()
        {

            if (hasChanged)
            {
                SetMemoizedToString();
                hasChanged = false;
                return ToString();
            }
            return memoizedToString;
        }

        private void SetMemoizedToString()
        {

            if (GetAltitudeInFeet() > 5000)
            {
                this.memoizedToString = "fl " + GetAltitudeAsFlightLevel(1).ToString();
            }
            else
            {
                string str = GetAltitudeInFeet().ToString();


                Stack<char> charStack = new Stack<char>(str);
                int numberOfItemsAdded = 0;

                for (int i = 0; i < charStack.Count; i++)
                {
                    if (numberOfItemsAdded % 3 == 0 && numberOfItemsAdded != 0)
                        this.memoizedToString += ',';

                    this.memoizedToString += charStack.Pop();
                    numberOfItemsAdded++;
                    i--;
                }

                charStack = new Stack<char>(memoizedToString);
                this.memoizedToString = "";

                foreach (var item in charStack)
                    this.memoizedToString += item;

                this.memoizedToString += " ft";
            }





        }

        public IAltitude Decrement(float rateOfDescentPerPeriod = 1f)
        {
            return new Altitude(this.feet - rateOfDescentPerPeriod);
        }

        public IAltitude Increment(float rateOfDescentPerPeriod = 1f)
        {
            return new Altitude(this.feet + rateOfDescentPerPeriod);
        }

        public string GetAltitudeAsFlightLevel()
        {
            return GetAltitudeAsFlightLevel(0);
        }

        public static bool AltitudeIsValid(ref string errorMessage, string text, AltitudeTypeEnum? altitudeType = null)
        {
            if (altitudeType == null)
            {
                errorMessage = "Altitude type was not selected";
                return text == "";
            }


            switch (altitudeType)
            {
                case AltitudeTypeEnum.FlightLevel:
                    try
                    {
                        var val = Int128.Parse(text);
                        return val < 100 && val > -1;
                    }
                    catch (Exception)
                    {
                        return text == "";
                    }
                case AltitudeTypeEnum.Feet:
                    try
                    {
                        var val = Int128.Parse(text);
                        return val < 100000 && val > -1;
                    }
                    catch (Exception)
                    {
                        return text == "";
                    }
                default:
                    throw new Exception("Altitude Type not yet supported");
            }
        }

        public static AltitudeTypeEnum? AltitudeTypeEnumFromString(string text)
        {
            switch (text.ToLower())
            {
                case "":
                    return null;
                case "flight level":
                    return AltitudeTypeEnum.FlightLevel;
                case "feet":
                    return AltitudeTypeEnum.Feet;
                default:
                    throw new Exception($"Could not parse {text}");
            }
        }
    }
        public enum AltitudeTypeEnum
        {
            FlightLevel,
            Feet,
        }
    }

    