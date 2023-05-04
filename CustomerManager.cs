using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    class CustomerManager
    {
        private int maxCustomers;
        private Customer[] customerList;

        public CustomerManager(int max)
        {
            maxCustomers = max;
            customerList = new Customer[maxCustomers];
        }

        public static Customer[] customerDatabase()
        {
            string path = "customerDB.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            int lnCount = File.ReadLines("customerDB.txt").Count();
            StreamReader input = new StreamReader("customerDB.txt", true);
            Customer[] list = new Customer[lnCount];
            string[] customerList;
            int count = 0;
            while (input.Peek() != -1)
            {
                customerList = input.ReadLine().Split(',');
                list[count++] = new Customer(customerList[0], customerList[1], customerList[2]);
            }
            input.Close();
            return list;
        }

        public int numOfCust()
        {
            int lnCount = File.ReadLines("customerDB.txt").Count();
            return lnCount;
        }

        public bool addCustomer(string fname, string lname, string ph)
        {
            Customer[] list = customerDatabase();
            if (numOfCust() < maxCustomers)
            {   
                
                StreamWriter outputFile = new StreamWriter("customerDB.txt", true);
                Customer c = new Customer(fname, lname, ph);
                outputFile.WriteLine(c);
                outputFile.Close();
                return true;
            }
            return false;
        }

        //Find customer by name
        public int findCustomerByName(string fName, string lName, string phone)
        {
            Customer[] list = customerDatabase();
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getFirstName() == fName && list[x].getLastName() == lName && list[x].getPhone() == phone)
                    return x;
            }
            return -1;
        }

        //Check if customer exists
        public bool customerExists(string fName, string lName, string phone)
        {
            int loc = findCustomerByName(fName, lName, phone);
            if (loc == -1) { return false; }
            return true;
        }

        //Finds customer
        public int findCustomer(int cid)
        {
            Customer[] list = customerDatabase();
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getId() == cid)
                    return x;
            }
            return -1;
        }

        public int findCustomer(string name)
        {
            Customer[] list = customerDatabase();
            for (int x = 0; x < list.Length; x++)
            {
                if (list[x].getFullName() == name)
                    return list[x].getId();
            }
            return -1;
        }

        //Check if customer exists by ID
        public bool customerExists(int id)
        {
            int loc = findCustomer(id);
            if (loc == -1) { return false; }
            return true;
        }

        //Grabs the booking information
        public bool getBookings()
        {
            Customer[] list = customerDatabase();
            for (int x = 0; x < numOfCust(); x++)
            {
                if (list[x].getNumBookings() == 0)
                    return true;
            }
            return false;
        }

        //Deletes a customer
        public bool deleteCustomer(int cid)
        {
            List<Customer> list = customerDatabase().ToList();
            int customer = findCustomer(cid);
            bool bookings = getBookings();
            if (customer == -1 && bookings == true) { return false; }
            list.RemoveAt(customer);
            StreamWriter outputFile = new StreamWriter("customerDB.txt");
            for (int x = 0; x < list.Count; x++)
            {
                Customer c = new Customer(list[x].getFirstName(), list[x].getLastName(), list[x].getPhone());
                outputFile.WriteLine(c);
            }
            outputFile.Close();
            return true;
        }

        //Get customer by ID
        public Customer getCustomer(int id)
        {
            Customer[] list = customerDatabase();
            return list[findCustomer(id)];
        }

        public string viewCustomers()
        {
            Customer[] list = customerDatabase();
            string s = "Customer List:\n";
            for (int x = 0; x < list.Length; x++)
            {
                s = s + "\nID: " + list[x].getId() + "\nFirst Name: " + list[x].getFirstName() + "\nLast Name: " + list[x].getLastName() + "\nPhone Number: " + list[x].getPhone() + "\nBookings: " + list[x].getNumBookings();
            }
            return s;
        }


    }
}
