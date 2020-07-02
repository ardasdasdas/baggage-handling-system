using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baggage_handling_system
{
    public class Airline
    {
        public static List<Flight> FlightList = new List<Flight>();
        public static string FlightFilePath = @"data/Flight.csv";
        public static List<Passenger> passengerList = new List<Passenger>();
        public static string PassangerFilePath = @"data/Passanger.csv";
    }
}