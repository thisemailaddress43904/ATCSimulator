using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATC2027.Library.FlightNumber
{
    public class FlightNumber(string flightNumber)
    {
        private string flightNumber = flightNumber;

        public string getFlightNumber() { return flightNumber; }

        public override string ToString()
        {
            return flightNumber;
        }
        public static bool FlightNumberIsValid(ref string errorMessage, string text)
        {
            bool result = Regex.IsMatch(text,"[A-Z][A-Z]\\d\\d\\d\\d");
            if (!result)
                errorMessage = "flight number was not valid";

            return result;
        }
    }
}
