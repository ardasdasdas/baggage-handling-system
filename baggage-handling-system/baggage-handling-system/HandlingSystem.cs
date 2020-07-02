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
    public partial class HandlingSystem : Form
    {
        int counter;
        public static bool LostPropertyEnabled = false;
        public static int LoadWay = 1;
        public static int LostPropertyWay;
        public static int index;
        public static string ID;
        public static string BaggageListFilePath;
        public static HandlingSystem handlingSystem = new HandlingSystem();
        public HandlingSystem()
        {
            InitializeComponent();
        }

        private void BaggageCheck_Click(object sender, EventArgs e)
        {
            btnBaggageCheck.Enabled = false;
            btnSecurity.Enabled = true;
            Way1Timer.Start();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            Way2Timer.Start();
            btnSecurity.Enabled = false;
            btnSort.Enabled = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Way3Timer.Start();
            btnSort.Enabled = false;
            btnLoad.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (HandlingSystem.LoadWay == 1)
                Way4Timer.Start();
            else
                Way8Timer.Start();

            btnLoad.Enabled = false;
            btnUnload.Enabled = true;
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            Way5Timer.Start();
            btnArrival.Enabled = true;
            btnUnload.Enabled = false;
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            if(Unload.TransferFlag == false)
            {
                Way6Timer.Start();
            }
            btnArrival.Enabled = false;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(Unload.TransferFlag)
                Way7Timer.Start();
        }

        private void btnLostPropertyTable_Click(object sender, EventArgs e)
        {
            if (LostPropertyEnabled == true)
            {
                if (LostPropertyWay == 9)
                    Way9Timer.Start();
                if (LostPropertyWay == 10)
                    Way10Timer.Start();
                if (LostPropertyWay == 11)
                    Way11Timer.Start();
                btnArrival.Enabled = false;
                btnLoad.Enabled = false;
                btnTransfer.Enabled = false;
                btnUnload.Enabled = false;
                btnLostPropertyTable.Enabled = false;
            }
        }

        private void Way1Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            BagageCheck bagageCheck = new BagageCheck();
            Count(panel1, panel2, panel3, bagageCheck, Way1Timer, btnBaggageCheck);
            btnBaggageCheck.Enabled = false;
        }

        private void Way2Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Security security = new Security();
            Count(panel4, panel5, panel6, security, Way2Timer, btnSecurity);
            btnSecurity.Enabled = false;
        }

        private void Way3Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Sort sort = new Sort();
            Count(panel7, panel8, panel9, sort, Way3Timer, btnSort);
            btnSort.Enabled = false;
        }

        private void Way4Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Load load = new Load();
            Count(panel10, panel11, panel12, load, Way4Timer, btnLoad);
            btnLoad.Enabled = false;
        }

        private void Way5Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Unload unload = new Unload();
            Count(panel13, panel14, panel15, unload, Way5Timer, btnUnload);
        }

        private void Way6Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Arrival arrival = new Arrival();
            Count(panel16, panel17, panel18, arrival, Way6Timer, btnArrival);
            btnArrival.Enabled = false;
        }

        private void Way7Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Transfer transfer = new Transfer();
            Count(panel19, panel20, panel21, transfer, Way7Timer, btnTransfer);
        }

        private void Way8Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            Load load = new Load();
            Count(panel22, panel23, panel24, load, Way8Timer, btnLoad);
        }

        private void Way9Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            LostPropertyTable lostPropertyTable = new LostPropertyTable();
            Count(panel25, panel26, panel27, lostPropertyTable, Way9Timer, btnLostPropertyTable);
        }

        private void Way10Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            LostPropertyTable lostPropertyTable = new LostPropertyTable();
            Count(panel28, panel29, panel30, lostPropertyTable, Way10Timer, btnLostPropertyTable);
        }

        private void Way11Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            LostPropertyTable lostPropertyTable = new LostPropertyTable();
            Count(panel31, panel32, panel33, lostPropertyTable, Way11Timer, btnLostPropertyTable);
        }

        private void Count(Panel panel1, Panel panel2, Panel panel3, Form A, Timer t, Button btn)
        {
            if (counter == 4)
            {
                panelMove(panel3, panel1);
            }
            if (counter == 8)
            {
                panelMove(panel1, panel2);
            }
            if (counter == 12)
            {
                panelMove(panel2, panel3);
            }
            if (counter == 16)
            {
                panelMove(panel1, panel3);
                Open(A);
                counter = 0;
                panel3.BackColor = Color.White;
                t.Stop();
                btn.BackColor = Color.Green;
            }
        }

        private void panelMove(Panel panel1, Panel panel2)
        {
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.Green;
        }

        private void Open(Form A)
        {
            A.Show();
            this.Hide();
        }

        private void btnBackCheckIn_Click(object sender, EventArgs e)
        {
            handlingSystem = new HandlingSystem();
            Check_In check_In = new Check_In();
            check_In.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
