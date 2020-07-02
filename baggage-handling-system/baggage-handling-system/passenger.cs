using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baggage_handling_system
{
    public class Passenger
    {
        private string ID;
        private string FlightNo;
        private bool transfer;
        private bool ExtraBaggageAllowance = false;
        private List<Baggage> baggages = new List<Baggage>();

        /**
        *  @brief   : This method set ID value and also return ID value.  
        */
        public string ID1 { get => ID; set => ID = value; }
        public string FlightNo1 { get => FlightNo; set => FlightNo = value; }
        public bool ExtraBaggageAllowance1 { get => ExtraBaggageAllowance; set => ExtraBaggageAllowance = value; }
        public List<Baggage> Baggages { get => baggages; set => baggages = value; }
        public bool Transfer { get => transfer; set => transfer = value; }

        public Passenger(string _ID, string flightNo, bool extraBaggageAllowence, bool transfer, List<Baggage> _baggages)
        {
            ID = _ID;
            FlightNo = flightNo;
            ExtraBaggageAllowance = extraBaggageAllowence;
            Transfer = transfer;
            baggages = _baggages;
        }

        public bool IsValid(string ID , string flightNo)
        {
            return (this.ID.Equals(ID) && this.FlightNo1.Equals(flightNo));
        }
    }
}