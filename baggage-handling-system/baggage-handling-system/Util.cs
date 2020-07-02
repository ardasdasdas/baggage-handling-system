using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace baggage_handling_system
{
    public class Util
    {
        private static int passengerNo = 1;
        private static int flightNo = 1;

        public static void saveXMLFile(Passenger psg)
        {
            XDocument xDoc = XDocument.Load(@"data/passengerXML.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementPassenger = new XElement("passenger");
            XAttribute passengerAttribute = new XAttribute("passengerNo", passengerNo.ToString());
            passengerNo++;
            XElement passengerID = new XElement("passengerID", psg.ID1);
            XElement passengerFlightNo = new XElement("flightNo", psg.FlightNo1);
            XElement passengerExtraBaggageAllowance = new XElement("extraBaggageAllowance", psg.ExtraBaggageAllowance1);
            XElement passengerTransfer = new XElement("transfer", psg.Transfer);
            XElement baggageListElement = new XElement("baggageList");
            for (int i = 0; i < psg.Baggages.Count; i++)
            {
                XElement newElementBaggage = new XElement("baggage");
                XAttribute bagggeAttribute = new XAttribute("baggageNo", (i + 1).ToString());
                XElement baggagesuspicions = new XElement("suspicions", psg.Baggages[i].Suspicios);
                XElement baggageID = new XElement("baggageID", psg.Baggages[i].BaggageID);
                XElement baggageWeight = new XElement("baggageWeight", psg.Baggages[i].Weight);
                XElement baggageOwner = new XElement("owner", psg.Baggages[i].Owner); ;
                XElement baggageLocation = new XElement("baggageLocation", psg.Baggages[i].BaggageLocation); ;
                newElementBaggage.Add(bagggeAttribute, baggagesuspicions, baggageID, baggageWeight, baggageOwner, baggageLocation);
                baggageListElement.Add(newElementBaggage);
            }
            newElementPassenger.Add(passengerAttribute, passengerID, passengerFlightNo, passengerExtraBaggageAllowance,
                passengerTransfer, baggageListElement);
            rootElement.Add(newElementPassenger);
            xDoc.Save(@"data/passengerXML.xml");
        }

        public static void saveXMLFile(Flight flg)
        {
            XDocument xDoc = XDocument.Load(@"data/flightXML.xml");
            XElement rootElement = xDoc.Root;
            XElement newElementFlight = new XElement("flight");
            XAttribute FlightAttribute = new XAttribute("number", Util.flightNo);
            Util.flightNo++;
            XElement flightNo = new XElement("FlightNo", flg.FlightNo1);
            newElementFlight.Add(FlightAttribute, flightNo);
            rootElement.Add(newElementFlight);

            xDoc.Save(@"data/flightXML.xml");
        }

        public static void readFlightXMLFile(List<Flight> flightList)
        {
            XDocument xDoc = XDocument.Load(@"data/flightXML.xml");
            XElement rootElement = xDoc.Root;
            foreach (XElement flights in rootElement.Elements())
            {
                string temp = flights.FirstAttribute.Value;
                flightNo = Int32.Parse(temp);
                Flight tempFlight = new Flight(flights.Element("FlightNo").Value);
                flightList.Add(tempFlight);
            }
            flightNo++;
        }

        public static void readPassengerXMLFile(List<Passenger> passengerList)
        {
            XDocument xDoc = XDocument.Load(@"data/passengerXML.xml");
            XElement passengerRootElement = xDoc.Root;
            foreach (XElement passenger in passengerRootElement.Elements())
            {
                passengerNo = Int32.Parse(passenger.FirstAttribute.Value);
                List<Baggage> tempBaggageList = new List<Baggage>();

                XElement baggageRootElement = passenger.Element("baggageList");
                foreach (XElement baggage in baggageRootElement.Elements())
                {
                    Baggage bagg = new Baggage(bool.Parse(baggage.Element("suspicions").Value),
                    double.Parse(baggage.Element("baggageWeight").Value), baggage.Element("baggageID").Value,
                    baggage.Element("owner").Value, baggage.Element("baggageLocation").Value);
                    tempBaggageList.Add(bagg);
                }
                Passenger pass = new Passenger(passenger.Element("passengerID").Value, passenger.Element("flightNo").Value,
                    bool.Parse(passenger.Element("extraBaggageAllowance").Value), bool.Parse(passenger.Element("transfer").Value)
                    , tempBaggageList);
                passengerList.Add(pass);
            }
            passengerNo++;
        }
    }
}