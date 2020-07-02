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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void btnBaggageLoad_Click(object sender, EventArgs e)
        {
            string lostBaggagesName = "";
            bool flag = false;
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count; i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner == "")
                {
                    lostBaggagesName += Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID + ",";
                    flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show(lostBaggagesName + " is/are lost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HandlingSystem.LostPropertyEnabled = true;
                HandlingSystem.LostPropertyWay = 10;
            }
            else
            {
                MessageBox.Show("Baggage loading is complete." + " The plane is ready to take off.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Load_Timer.Start();
        }
        int time = 0;
        private void Load_Timer_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 2)
            {
                Load_Timer.Stop();
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
