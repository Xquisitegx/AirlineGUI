using System;
using System.Windows.Forms;

namespace AirlineGUI
{
    public partial class AddCustomer : Form
    {

        public AddCustomer()
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

        //Starting of Switch Forms
        private void btnAddCustomer_Click(object sender, EventArgs e)
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

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooking ab = new AddBooking();
            ab.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fnameTextBox.Clear();
            lnameTextBox.Clear();
            phTextBox.Clear();
        }

        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFlight vf = new ViewFlight();
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
            DeleteFlight df = new DeleteFlight();
            df.ShowDialog();
            this.Close();
        }
        //End of switcehing forms

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

        //Creates a customer and validate textbox
        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            string fname = (fnameTextBox.Text);
            string lname = (lnameTextBox.Text);
            string ph = (phTextBox.Text);
            if (String.IsNullOrEmpty(fnameTextBox.Text) || String.IsNullOrEmpty(lnameLabel.Text) || String.IsNullOrEmpty(phTextBox.Text))
            {
                MessageBox.Show("Uh Oh...Information Is Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Successfully added customer!", "Successful", MessageBoxButtons.OK);
                Program.addCustomer(fname, lname, ph);
            }
        }
    }
}
