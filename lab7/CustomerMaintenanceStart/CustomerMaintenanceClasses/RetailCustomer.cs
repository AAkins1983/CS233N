using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class RetailCustomer : Customer
    {
        private string homePhone;

        public RetailCustomer()
        { }

        public RetailCustomer(string firstName, string lastName,
            string email, string hPhone) : base(firstName, lastName, email)
        {
            homePhone = hPhone;
        }

        public string HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
            }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " " + homePhone;
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
