using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        // Instance variables - "private" for data hiding
        protected string fName;
        protected string lName;
        protected string eMail;

        public Customer()
        {
            fName = "???";
            lName = "???";
            eMail = "???";
        }

        public Customer(string firstName, string lastName, string eMailAddress)
        {
            fName = firstName;
            lName = lastName;
            eMail = eMailAddress;
        }

        //
        public string FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }

        public string Email
        {
            get
            {
                return eMail;
            }
            set
            {
                eMail = value;
            }
        }

        public string GetDisplayText()
        {
            return fName + " " + lName + ", " + eMail;
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
