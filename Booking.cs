using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
	class Booking
	{
		private int bookingID;
		private string date;
		private Customer cm;
		private Flight fl;

		public Booking(string date, int bookingID, Customer cm, Flight fl)
		{
			this.bookingID = bookingID;
			this.date = date;
			this.cm = cm;
			this.fl = fl;

		}

		public int getId() { return bookingID; }
		public string getBookingDate() { return date; }
		public Flight getFlight() { return fl; }
		public Customer getCustomer() { return cm; }
		public string getFisrtName() { return cm.getFirstName(); }
		public string getLastName() { return cm.getLastName(); }
		public int getFlightNo() { return fl.getFlightNumber(); }
		public int getCustomerId() { return cm.getId(); }

		public string toString()
		{
			string s = "Booking ID: " + bookingID;
			s = s + "\nBooking Date: " + date;
			s += "\nFlight Number: " + fl.getFlightNumber();
			s += "\nCustomer Name:" + cm.getFirstName() + " " + cm.getLastName(); ;

			return s;
		}
		public override string ToString()
		{
			string s = bookingID + "," + date + "," + fl.getFlightNumber() + "," + cm.getFirstName() + "," + cm.getLastName();
			return s;
		}
	}
}
