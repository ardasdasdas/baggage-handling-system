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
    public partial class BagageCheck : Form
    {
        public BagageCheck()
        {
            InitializeComponent();
        }

        private void btnWeigh_Click(object sender, EventArgs e)
        {
            double SumWeight = 0;
            Airport airport = new Airport();
            airport.Location = "Origin Airport";
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count(); i++)
            {
                SumWeight += Airline.passengerList[HandlingSystem.index].Baggages[i].Weight;
                Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageLocation = airport.Location;
            }
            lblWeight.Text = SumWeight.ToString() + " kg";
            if (SumWeight <= 20 && SumWeight >= 0)
            {
                MessageBox.Show("The total weight of your baggages weight are appropriate.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                HandlingSystem.handlingSystem.Show();
                this.Hide();
            }
            else if (SumWeight > 20 && Airline.passengerList[HandlingSystem.index].ExtraBaggageAllowance1)
            {
                MessageBox.Show("Since you have an extra baggage allowance, the total weight of your baggages are appropriate.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                HandlingSystem.handlingSystem.Show();
                this.Hide();
            }
            else if (SumWeight > 20)
            {
                MessageBox.Show("Your baggage weight is over 20kg.\nPlease purchase additional baggage allowance.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnBuyExtraBaggage.Visible = true;
                btnWeigh.Visible = false;
            }
        }

        private void btnBuyExtraBaggage_Click(object sender, EventArgs e)
        {
            Airline.passengerList[HandlingSystem.index].ExtraBaggageAllowance1 = true;
            btnBuyExtraBaggage.Visible = false;
            btnWeigh.Visible = true;
            MessageBox.Show("You purchased extra baggage allowance,\nPlease re-weigh your baggages","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblWeight.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
