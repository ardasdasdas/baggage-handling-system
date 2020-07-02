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
    public partial class Security : Form
    {
        int suspiciousBaggageIndex = 0;
        public Security()
        {
            InitializeComponent();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            bool control = false;
            HandlingSystem.BaggageListFilePath = @"data/" + HandlingSystem.ID + "BaggageList.csv";
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count(); i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Suspicios == true)
                {
                    control = true;
                    suspiciousBaggageIndex = i;
                }
            }
            if (control == false)
            {
                txtSuspicious.Text = "not suspicious.";
                MessageBox.Show("Your baggage is not suspicious.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerSecurity.Start();
            }
            else
            {
                txtSuspicious.Text = "suspicious. You have to discard the suspicious things.";
                btnDiscard.Visible = true;
                btnSecurity.Visible = false;
            }
        }

        private void timerSecurity_Tick(object sender, EventArgs e)
        {
            HandlingSystem.handlingSystem.Show();
            this.Hide();
            timerSecurity.Stop();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Airline.passengerList[HandlingSystem.index].Baggages[suspiciousBaggageIndex].Suspicios = false;
            MessageBox.Show("The thing causing the security problem has been discarded.");
            btnDiscard.Visible = false;
            btnSecurity.Visible = true;
            txtSuspicious.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
