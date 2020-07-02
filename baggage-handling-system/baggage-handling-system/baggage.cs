using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baggage_handling_system
{
    public class Baggage
    {
        private bool suspicious = true;
        private double weight;
        private string baggageID;
        private string owner;
        private string baggageLocation;

        public Baggage(bool suspicios, double weight, string baggageID, string owner, string airportLocation)
        {
            this.suspicious = suspicios;
            this.weight = weight;
            this.baggageID = baggageID;
            this.owner = owner;
            this.BaggageLocation = airportLocation;
        }

        public bool Suspicios { get => suspicious; set => suspicious = value; }
        public double Weight { get => weight; set => weight = value; }
        public string BaggageID { get => baggageID; set => baggageID = value; }
        public string Owner { get => owner; set => owner = value; }
        public string BaggageLocation { get => baggageLocation; set => baggageLocation = value; }
    }
}
