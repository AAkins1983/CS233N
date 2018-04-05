using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Stuff
{
    public partial class stringForm : Form
    {
        public stringForm()
        {
            InitializeComponent();
        }

        private string SwitchCase(string input)
        {
            string output = "";
            return output;
        }

        private string Reverse(string input)
        {
            string output = "";
            return output;
        }

        private string PigLatin(string input)
        {
            string output = "";
            return output;
        }

        private string ShiftCypher(string input, int charsToShift)
        {
            string output = "";
            return output;
        }

        private string SubCypher(string input, string charsToSub)
        {
            string output = "";
            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);

        }
    }
}
