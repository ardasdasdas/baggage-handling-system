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
    public partial class LostPropertyTable : Form
    {
        public LostPropertyTable()
        {
            InitializeComponent();
        }

        private void btnFindLostBaggage_Click(object sender, EventArgs e)
        {
            string baggageControl = "";
            Airport airport = new Airport();
            if (HandlingSystem.LostPropertyWay == 9 || HandlingSystem.LostPropertyWay == 10)
                airport.Location = "Origin Airport";
            else
                airport.Location = "Destination Airport";
            txtBoxBaggageID.Text = "," + txtBoxBaggageID.Text;
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count(); i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner == "")
                {
                    baggageControl += "," + Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID.ToString();
                    Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageLocation = airport.Location;
                }
            }
            if (baggageControl == txtBoxBaggageID.Text)
            {
                MessageBox.Show("You can take the your baggages.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lost_Timer.Start();
            }
            else
                MessageBox.Show("No baggage for this number was found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtBoxBaggageID.Text = "";
        }
        int counter = 0;
        private void Lost_Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                Lost_Timer.Stop();
                HandlingSystem.handlingSystem.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
