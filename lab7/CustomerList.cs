using System;
using System.Collections.Generic;

namespace CustomerMaintenanceClasses
{
    // This is the solution to exercise 13-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public class CustomerList
	{
		private List<Customer> customers;

        public delegate void ChangeHandler(CustomerList customers);
        public event ChangeHandler Changed;

		public CustomerList()
		{
            customers = new List<Customer>();
		}

		public int Count
		{
			get
			{
				return customers.Count;
			}
		}

		public Customer this[int i]
		{
			get
			{
				return customers[i];
			}
			set
			{
				customers[i] = value;
				Changed(this);
			}
		}

		public void Fill()
		{
			customers = CustomerDB.GetCustomers();
		}

		public void Save()
		{
			CustomerDB.SaveCustomers(customers);
		}

		public void Add(Customer customer)
		{
			customers.Add(customer);
			Changed(this);
		}

		public void Remove(Customer customer)
		{
			customers.Remove(customer);
			Changed(this);
		}

		public static CustomerList operator + (CustomerList c1, Customer c)
		{
			c1.Add(c);
			return c1;
		}

		public static CustomerList operator - (CustomerList c1, Customer c)
		{
			c1.Remove(c);
			return c1;
		}

	}
}
