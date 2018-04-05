using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        private List<Customer> customers = new List<Customer>();

        public CustomerList() { }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public void Add(Customer bob)
        {
            customers.Add(bob);
        }

        public void Remove(Customer bob)
        {
            customers.Remove(bob);
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer c in customers)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }

        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
