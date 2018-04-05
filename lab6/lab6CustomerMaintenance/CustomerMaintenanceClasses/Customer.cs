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
        private string fName;
        private string lName;
        private string eMail;

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

        public string FirstName
        {
            get
            {
                return fName;
            }
            set
            {
                //if (value.Length > 30)
                    //throw new ArgumentOutOfRangeException("Must be less than 30 characters.");                                   
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
                ;// if (value.Length > 30)
                   //throw new ArgumentOutOfRangeException("Must be less than 30 characters.");
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
                //if (value.Length > 30)
                    //throw new ArgumentOutOfRangeException("Must be less than 30 characters.");
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
