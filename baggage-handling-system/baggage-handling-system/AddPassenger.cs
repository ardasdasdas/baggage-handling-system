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
    public partial class AddPassenger : Form
    {
        static List<Baggage> baggList = new List<Baggage>();
        public AddPassenger()
        {
            InitializeComponent();
        }

        private void btnBackCheckIn_Click(object sender, EventArgs e)
        {
            Check_In check_In = new Check_In();
            check_In.Show();
            this.Hide();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                Flight flg = new Flight(txtBoxAddFlightFlightNo.Text);
                Util.saveXMLFile(flg);
                MessageBox.Show("Flight was added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                Passenger passenger = new Passenger(txtBoxAddPassengerID.Text, txtBoxAddPassengerFlightNo.Text,
               false, bool.Parse(cmbBoxAddPassengerTransfer.Text), baggList);
                Util.saveXMLFile(passenger);
                baggList.Clear();
                MessageBox.Show("Passenger was added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddBaggage_Click(object sender, EventArgs e)
        {
            try
            {
                string airportLocation = "Departure Airport";
                Baggage tempBagg = new Baggage(bool.Parse(cmbBoxAddBaggageSuspicions.Text),
               double.Parse(txtBoxAddBaggageWight.Text), txtBoxAddBaggageBaggageID.Text, txtBoxAddBaggageOwner.Text, airportLocation);
                baggList.Add(tempBagg);
                MessageBox.Show("Baggage was added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
