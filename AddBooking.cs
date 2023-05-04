using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineGUI
{
    public partial class AddBooking : Form
    {
        public AddBooking()
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
        
        //Start of Switching Forms
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

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBooking ab = new AddBooking();
            ab.ShowDialog();
            this.Close();
        }

        private void btnDeleteFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFlight df = new DeleteFlight();
            df.ShowDialog();
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

        private void btnCus_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file = new StreamReader("customerDB.txt");
            List<string> list = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                if (cusBox.Items.Contains(line))
                {
                    btnCus.Enabled = true;
                }
                else
                {
                    cusBox.Items.Add(line);
                    list.Add(line);
                    counter++;
                }
            }
            string[] arr = list.ToArray();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file = new StreamReader("flightDB.txt");
            List<string> list = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                if (flightBox.Items.Contains(line))
                {
                    flightBox.Enabled = true;
                }
                else
                {
                    flightBox.Items.Add(line);
                    list.Add(line);
                    counter++;
                }
            }
            string[] arr = list.ToArray();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int fn;
            int cid;
            string bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            if (!int.TryParse(cusIdTextBox.Text, out cid) || (!int.TryParse(flightIdTextBox.Text, out fn)))
            {
                MessageBox.Show("No Information Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Successfully Created Booking!", "Successful", MessageBoxButtons.OK);
                //Program.addBooking(new Booking(bookingDate, new Customer(fname, lname, ph), new Flight(fn, or, dest, mSeats));
            }
        }
    }
}
