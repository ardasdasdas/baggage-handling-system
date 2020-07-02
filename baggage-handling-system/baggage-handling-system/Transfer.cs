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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void TransferTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                TransferTimer.Stop();
                HandlingSystem.LoadWay = 2;
                HandlingSystem.handlingSystem.Show();
                this.Hide();
                return;
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string BaggageTransfer = "";
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count; i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner != "")
                {
                    BaggageTransfer += "Baggage number " + Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID + " is being transferred."
                      + Environment.NewLine;
                }
            }
            MessageBox.Show(BaggageTransfer, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TransferTimer.Start();
            HandlingSystem.handlingSystem.btnLoad.Enabled = true;
        }
    }
}
