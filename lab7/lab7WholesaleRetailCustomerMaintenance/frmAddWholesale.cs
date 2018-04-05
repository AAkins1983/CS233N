using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace WholesaleRetailCustomerMaintenance
{
    // This is the starting point for exercise 14-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmAddWholesale : Form
    {
        public frmAddWholesale()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                // TODO: Add code that creates a new wholesale customer
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsPresent(txtEmail) &&
                Validator.IsPresent(txtCompany);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}