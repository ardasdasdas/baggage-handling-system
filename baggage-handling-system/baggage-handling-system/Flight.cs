using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baggage_handling_system
{
    public class Flight
    {
        private string FlightNo;
        
        public Flight(string flightNo)
        {
            FlightNo = flightNo;
        }

        public string FlightNo1 { get => FlightNo; set => FlightNo = value; }

        public bool IsValid(string flightNo)
        {
            return this.FlightNo1.Equals(flightNo);
        }
    }
}
