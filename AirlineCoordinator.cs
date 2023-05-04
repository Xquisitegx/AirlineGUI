using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bManager;

        public AirlineCoordinator(int maxCust, int maxFlights, int maxBookings)
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(maxCust);
            bManager = new BookingManager(flManager, custManager);
        }

        public bool addFlight(int flNo, string or, string dest, int mSeats)
        {
            return flManager.addFlight(flNo, or, dest, mSeats);
        }


        public string flightList()
        {
            return flManager.getFlightList();
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }

        public bool addCustomer(string fName, string lName, string phone)
        {
            return custManager.addCustomer(fName, lName, phone);
        }

        public string customersList()
        {
            return custManager.viewCustomers();
        }


        public string bookingsList()
        {
            return bManager.viewBookings();
        }

        public bool customerExists(string fName, string lName, string phone)
        {
            return custManager.customerExists(fName, lName, phone);
        }

        public bool customerExists(int id)
        {
            return custManager.customerExists(id);
        }

        public bool flightExists(int fid)
        {
            return flManager.flightExists(fid);
        }
        public Flight getFlight(int id)
        {
            return flManager.getFlight(id);
        }

        public bool hasSpace()
        {
            return flManager.hasSpace();
        }

        public bool deleteCustomer(int cid)
        {
            return custManager.deleteCustomer(cid);
        }

        public bool getBookings()
        {
            return custManager.getBookings();
        }

        public bool getPassengers()
        {
            return flManager.getPassengers();
        }

        public bool addBooking(int custID, int flightNum)
        {
            return bManager.addBooking(custID, flightNum);


        }
        public string bookingList()
        {
            return bManager.viewBookings();
        }
    }
}
