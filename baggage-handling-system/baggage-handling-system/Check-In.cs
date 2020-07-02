using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baggage_handling_system
{
    public partial class Check_In : Form
    {
        public Check_In()
        {
            Airline.passengerList.Clear();
            Airline.FlightList.Clear();
            Util.readPassengerXMLFile(Airline.passengerList);
            Util.readFlightXMLFile(Airline.FlightList);
            InitializeComponent();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string FlightNo = txtFlightNo.Text;
            for (int i = 0; i < Airline.FlightList.Count; i++)
            {
                Flight flight = Airline.FlightList[i];
                if (flight.IsValid(FlightNo))
                {
                    Check(Airline.FlightList[i]);
                    return;
                }
            }
            MessageBox.Show("No flight found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Check(Flight flight)
        {
            string ID = txtID.Text;
            for (int i = 0; i < Airline.passengerList.Count; i++)
            {
                Passenger passenger = Airline.passengerList[i];
                if (passenger.IsValid(ID, flight.FlightNo1))
                {
                    MessageBox.Show("Check-In OK","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    HandlingSystem.ID = ID;
                    HandlingSystem.index = i;
                    HandlingSystem.handlingSystem.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Check-In Failure","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            this.Hide();
            addPassenger.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
