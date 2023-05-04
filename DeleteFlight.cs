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
    public partial class DeleteFlight : Form
    {
        public DeleteFlight(string s)
        {
            InitializeComponent();
            textBox1.Text = s;
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
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlight af = new AddFlight();
            af.ShowDialog();
            this.Close();
        }

        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFlight vf = new ViewFlight(Program.viewFlights());
            vf.ShowDialog();
            this.Close();
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

        private void btnDeleteFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFlight df = new DeleteFlight(Program.viewFlights());
            df.ShowDialog();
            this.Close();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooking ab = new AddBooking();
            ab.ShowDialog();
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
