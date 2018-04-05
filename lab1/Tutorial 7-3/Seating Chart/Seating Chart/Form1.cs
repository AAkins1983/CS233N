using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            // Variables for the selected row and column
            int row, col;
            
            // Constants for the maximum row and column subscripts
            const int MAX_ROW = 5;
            const int MAX_COL = 3;

            // TODO:  Create an array with the seat prices.
            /*{ {450m, 450m, 450m, 450m},
                {425m, 425m, 425m, 425m},
                {400m, 400m, 400m, 400m},
                {375m, 375m, 375m, 375m},
                {375m, 375m, 375m, 375m},
                {350m, 350m, 350m, 350m}
               };
             */
            decimal[,] seatPrices = { {450m, 450m, 450m, 450m},
                                      {425m, 425m, 425m, 425m},
                                      {400m, 400m, 400m, 400m},
                                      {375m, 375m, 375m, 375m},
                                      {375m, 375m, 375m, 375m},
                                      {350m, 350m, 350m, 350m} 
                                    };

            // Get the selected row number.
            if (int.TryParse(rowTextBox.Text, out row)) // Converts value in "rowTextBox" to int and stores in row var.
            {                                           // If successful, continue; if unsuccessful, jump to line 79.
                // Get the selected column number.
                if (int.TryParse(colTextBox.Text, out col)) // Converts value in "colTextBox" to int and stoes in col var.
                {                                           // If successful, continue; if unsuccessful, jump to line 73.
                    // Make sure the row is within range.
                    if (row >= 0 && row <= MAX_ROW) // Determines if "row" is 0 - "MAX-ROW." If so, cont. if not jump to line 66.
                    {
                        // Make sure the column is within rnge.
                        if (col >= 0 && col <= MAX_COL) // Determines if "col" is 0 - "MAX-COL." If so, cont. if not jump to line 59.
                        {
                            // TODO:  Display the selected seat's price.
                            priceLabel.Text = seatPrices[row, col].ToString("c"); // Uses "row" and "col" as subscripts to get selected seat's price from "seatPrices" array,
                        }                                                         // then displays in "priceLabel" control.
                        else
                        {
                            // Error message for invalid column.
                            MessageBox.Show("Column must be 0 through " + 
                                MAX_COL);
                        }
                    }
                    else
                    {
                        // Error message for invalid row.
                        MessageBox.Show("Row must be 0 through " + 
                            MAX_ROW);
                    }
                }
                else
                {
                    // Display an error message for noninteger column.
                    MessageBox.Show("Enter an integer for the column.");
                }
            }
            else
            {
                // Display an error message for noninteger row.
                MessageBox.Show("Enter an integer for the row.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
