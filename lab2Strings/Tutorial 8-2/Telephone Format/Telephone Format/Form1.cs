using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digits = 0;  // The number of digits

            // Count the digits in str.
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    digits++;
            }

            // Return the number of digits.
            return digits;
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10;  // Length of a valid string
            bool valid = true;   // Flag to indicate validity

            if (str.Length == VALID_LENGTH &&
                NumberDigits(str) == VALID_LENGTH)
                valid = true;
            else
                valid = false;

            // Return the status.
            return valid;
        }

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        // phone number format is ###-###-####
        private void TelephoneFormat(ref string str)    // ref = will actuall manipulate str
        {
            //str = str.Insert(3, "-");   // to actually mutate str, put on left side of assignment statement rather than just str.Insert(3, "-");
            //str = str.Insert(7, "-");
            str = str.Substring(0, 3) + "-" +
                str.Substring(3, 3) + "-" +
                str.Substring(6);   // 1 parameter will automatically go to the end of the string.
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = numberTextBox.Text.Trim();

            // If the input is a valid number, format it
            // and display it.
            if (IsValidNumber(input))   // don't need == true
            {
                TelephoneFormat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
