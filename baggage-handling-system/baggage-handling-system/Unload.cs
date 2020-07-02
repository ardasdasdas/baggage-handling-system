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
    public partial class Unload : Form
    {
        public static bool TransferFlag = false;
        public Unload()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void Unload_Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            btnTransferCheck.Enabled = false;
            if (counter == 2)
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

        private void btnTransferCheck_Click(object sender, EventArgs e)
        {
            string lostBaggagesName = "";
            bool flag = false;
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count; i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner == "")
                {
                    lostBaggagesName += Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID
                        + Environment.NewLine;
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show(lostBaggagesName + " is/are lost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HandlingSystem.LostPropertyEnabled = true;
                HandlingSystem.LostPropertyWay = 11;
            }
            if (Airline.passengerList[HandlingSystem.index].Transfer)
            {
                lblBaggageTransferText.Text = "It will load the another flight.";
                TransferFlag = true;
                Airline.passengerList[HandlingSystem.index].Transfer = false;
                MessageBox.Show("It will load the another flight.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your baggage will go to the Baggage Claim. You can take the your baggage.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBaggageTransferText.Text = " Baggage Claim. You can take the your baggage.";
                TransferFlag = false;
            }
            Unload_Timer.Start();
        }
    }
}
