using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baggage_handling_system
{
    public partial class Sort : Form
    {
        public static string chooseGate = "1";

        public Sort()
        {
            InitializeComponent();
            for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count; i++)
            {
                if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner == "")
                {
                    chooseGate = "-1";
                    picBoxBlack.Visible = true;
                    break;
                }
            }
            if (chooseGate == "1")
            {
                picBoxBlue.Visible = true;
                picBoxRed.Visible = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MoveBaggage(chooseGate);
        }
        private void MoveBaggage(string gateNo)
        {
            int coordinateX1 = 391, coordinateY1 = 57, CoordinateLast = 816;
            int coordinateX2 = 391, coordinateY2 = 538;

            if (gateNo == "1")
            {
                movingUp(picBoxRed, coordinateX1, coordinateY1, CoordinateLast);
                movingDown(picBoxBlue, coordinateX2, coordinateY2, CoordinateLast);
            }
            else if (gateNo == "-1")
            {
                movingStraight(picBoxBlack, CoordinateLast);
                string losgBaggagesName = "";
                bool flag = false;
                for (int i = 0; i < Airline.passengerList[HandlingSystem.index].Baggages.Count; i++)
                {
                    if (Airline.passengerList[HandlingSystem.index].Baggages[i].Owner == "")
                    {
                        losgBaggagesName += Airline.passengerList[HandlingSystem.index].Baggages[i].BaggageID + ",";
                        flag = true;
                    }
                }
                if (flag)
                {
                    MessageBox.Show(losgBaggagesName + "is/are lost!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HandlingSystem.LostPropertyEnabled = true;
                    HandlingSystem.LostPropertyWay = 9;
                }
            }
            else
                movingDown(picBoxBlue, coordinateX2, coordinateY2, CoordinateLast);
            accessHandlingSystem.Start();
        }
        public void movingUp(PictureBox picBox, int coordinateX, int CoordinateY, int CoordinateLast)
        {
            int X_axis = 12;
            int Y_axis = 297;
            while (X_axis < CoordinateLast)
            {
                picBox.Location = new Point(X_axis, Y_axis);
                Thread.Sleep(3);
                if (X_axis < coordinateX)
                {
                    X_axis++;
                }
                if (X_axis == coordinateX)
                {
                    Y_axis--;
                }
                if (Y_axis == CoordinateY)
                {
                    X_axis++;
                }
            }
        }
        public void movingDown(PictureBox picBox, int coordinateX, int CoordinateY, int CoordinateLast)
        {
            int X_axis = 12;
            int Y_axis = 297;
            while (X_axis < CoordinateLast)
            {
                picBox.Location = new Point(X_axis, Y_axis);
                Thread.Sleep(3);
                if (X_axis < coordinateX)
                {
                    X_axis++;
                }
                if (X_axis == coordinateX)
                {
                    Y_axis++;
                }
                if (Y_axis == CoordinateY)
                {
                    X_axis++;
                }
            }
        }
        public void movingStraight(PictureBox picBox, int CoordinateLast)
        {
            int X_axis = 12;
            int Y_axis = 297;
            while (X_axis < CoordinateLast)
            {
                picBox.Location = new Point(X_axis, Y_axis);
                Thread.Sleep(3);
                X_axis++;
            }
        }
        int counter = 0;
        private void accessHandlingSystem_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 2)
            {
                HandlingSystem.LoadWay = 1;
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
