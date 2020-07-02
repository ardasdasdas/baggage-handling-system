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
    public partial class Arrival : Form
    {
        public Arrival()
        {
            InitializeComponent();
        }
        private void btnArrival_Click(object sender, EventArgs e)
        {
            string baggageControl = "";
            Airport airport = new Airport();
            airport.Location = "Destination Airport";
            txtboxBaggageID.Text = "," + txtboxBaggageID.Text;
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count(); i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner != "")
                {
                    baggageControl += "," + Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID.ToString();
                    Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageLocation = airport.Location;
                }
            }
            if (baggageControl == txtboxBaggageID.Text)
            {
                MessageBox.Show("You can take the your baggages.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ArrivalTimer.Start();
            }
            else
                MessageBox.Show("You can't take the another baggages which not yours.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtboxBaggageID.Text = "";
        }
        int counter = 0;
        private void ArrivalTimer_Tick(object sender, EventArgs e)
        {    
            counter++;
            if(counter==2)
            {
                HandlingSystem.handlingSystem.Show();
                this.Hide();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
