using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    class Customer
    {
        private static int IdCount = 1000;
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int numBookings;

        public Customer(string fname, string lname, string ph)
        {
            numBookings = 0;
            customerId = IdCount;
            firstName = fname;
            lastName = lname;
            phone = ph;
            IdCount++;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public string getFullName() { return firstName + lastName; }
        public int getNumBookings() { return numBookings; }


        public string toString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\nBookings: " + numBookings;

            return s;
        }

        public override string ToString()
        {
            string s = customerId + "," + firstName + "," + lastName + "," + phone + "," + numBookings;
            return s;
        }
    }
}
