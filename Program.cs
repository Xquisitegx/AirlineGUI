using System;
using System.Windows.Forms;

namespace AirlineGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aCoord = new AirlineCoordinator(100, 50, 50);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }

        static AirlineCoordinator aCoord;

        //Method for adding flight
        public static bool addFlight(int flNo, string or, string dest, int mSeats)
        {
            if (aCoord.addFlight(flNo, or, dest, mSeats))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Method for adding Customer
        public static bool addCustomer(string fName, string lName, string phone)
        {
            if (aCoord.addCustomer(fName, lName, phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method for adding a booking
        public static bool addBooking(int custId, int flightNo)
        {
            if (aCoord.addBooking(custId, flightNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string viewFlights()
        {
            string s = aCoord.flightList();
            return s;

        }
        //Method for Viewing customers
        public static string viewCustomers()
        {
            string s = aCoord.customersList();
            return s;
        }
        //Method to View bookings
        public static string viewBooking()
        {
            string s = aCoord.bookingList();
            return s;
        }
        //method to delete customer
        public static bool deleteCustomer(int cid)
        {
            if (aCoord.deleteCustomer(cid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method to delete flight
        public static bool deleteFlight(int fid)
        {
            if (aCoord.deleteFlight(fid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
