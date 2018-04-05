using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class WholesaleCustomer : Customer
    {
        private string company;

        public WholesaleCustomer()
        { }

        public WholesaleCustomer(string firstName, string lastName,
            string email, string comp) : base(firstName, lastName, email)
        {
            company = comp;
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

       /* public override string GetDisplayText()
        {
            return base.GetDisplayText() + " " + company;
        }*/

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
