using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    class BookingManager
    {
        private Booking[] bookingList;
        private FlightManager flMan;
        private CustomerManager custMan;


        public BookingManager(FlightManager flMan, CustomerManager custMan)
        {
            this.custMan = custMan;
            this.flMan = flMan;
        }

        //Grabs all information from Database
        public Booking[] getBookingsFromDatabase()
        {
            string path = "bookingDB.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            int lnCount = File.ReadLines("bookingDB.txt").Count();
            StreamReader input = new StreamReader("bookingDB.txt", true);
            Booking[] list = new Booking[lnCount];
            string[] bookinglist;
            int cnt = 0;
            char sep = ',';
            if (lnCount > 1)
            {
                while (input.Peek() != 1)
                {
                    bookinglist = input.ReadLine().Split(sep);
                    int customerID = custMan.findCustomer(bookinglist[2]);
                    Customer customer = custMan.getCustomer(customerID);
                    Flight flight = flMan.getFlight(Convert.ToInt32(bookinglist[3]));
                    list[cnt++] = new Booking(bookinglist[0], Convert.ToInt32(bookinglist[1]), customer, flight);
                }
                input.Close();
                return list;
            }
            else
            {
                input.Close();
                return null;
            }
        }

        //Reads each line in database
        public int numOfBooking()
        {
            int lnCount = File.ReadLines("bookingDB.txt").Count();
            return lnCount;
        }

        //Method for adding a booking
        public bool addBooking(int cid, int flNo)
        {
            if (flMan.getFlight(flNo).availableSeats() == 0 && flMan.getFlight(flNo).addPassenger(custMan.getCustomer(cid)))
            {
                return false;
            }
            StreamWriter output = new StreamWriter("bookingDB.txt", true);
            int bookID = bookingID();
            string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            Booking b = new Booking(date, bookID, custMan.getCustomer(cid), flMan.getFlight(flNo));
            output.WriteLine(b);
            output.Close();
            return true;
        }

        public int bookingID()
        {
            int bookingId = 100;
            bookingId++;
            return bookingId;
        }

        //Method to View Bookings
        public string viewBookings()
        {
            int lnCount = File.ReadLines("bookingDB.txt").Count();
            StreamReader file = new StreamReader("bookingDB.txt", true);
            string[] list;
            string s = "\nBooking List: \n";

            if (lnCount > 0)
            {
                while (file.Peek() != -1)
                {
                    list = file.ReadLine().Split(',');
                    s = s + "\nDate: " + list[0] + "\nBooking ID: " + list[1] + "\nCustomer Name: " + list[2] + "\nFlight Number: " + list[3];
                }
                file.Close();
            }
            file.Close();
            return s;
        }

    }
}
