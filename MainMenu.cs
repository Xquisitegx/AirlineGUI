using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineGUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Moveable Form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        //Starting of Switching Forms
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlight af = new AddFlight();
            af.ShowDialog();
            this.Close();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooking ab = new AddBooking();
            ab.ShowDialog();
            this.Close();
        }

        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            ViewFlight vf = new ViewFlight(Program.viewFlights());
            vf.Location = this.Location;
            vf.StartPosition = FormStartPosition.Manual;
            vf.Show();
            this.Hide();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomer vc = new ViewCustomer();
            vc.ShowDialog();
            this.Close();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCustomer dc = new DeleteCustomer();
            dc.ShowDialog();
            this.Close();
        }

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f1 = new MainMenu();
            f1.ShowDialog();
            this.Close();
        }

        private void btnDeleteFlights_Click(object sender, EventArgs e)
        {
            DeleteFlight df = new DeleteFlight(Program.viewFlights());
            df.Location = this.Location;
            df.StartPosition = FormStartPosition.Manual;
            df.Show();
            this.Hide();
        }
        //End of Switching Forms

        //Confirmation for when user exits program
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you would like to exit?", "Exiting Program", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Activate();
            }
            else
            {
                this.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
