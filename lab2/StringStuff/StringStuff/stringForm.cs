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

        // EXTRA CREDIT: Make work w/uppercase; keep spaces and punctuation.
        // EXTRA CREDIT: Pig Latin rules - first char vowel? More than one consantent, move to end. Let user say how much to shift.
        // Switches every uppercase to lowercase and vice versa.
        private string SwitchCase(string input)
        {
            string output = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    output += char.ToLower(c);
                else
                    output += char.ToUpper(c);
            }
            return output;
        }

        private string Reverse(string input)
        {
            string output = "";

            for (int i = input.Length-1; i >= 0; i--)
                output += input[i];
            return output;
        }

        private string PigLatin(string input)
        {
            string output = "";

            output = input.Substring(1) + input[0] + "ay"; 

            return output;
        }

        // Use split function
        private string PigSentence(string input)
        {
            string output = "";

            //Get the tokens from the string.
            string[] tokens = input.Split(null);

            // Display each token.
            foreach (string s in tokens)
                output += PigLatin(s) + " ";

            return output;
        }

        private string ShiftCypher(string input, int charsToShift)
        {
            string output = "";
            string alpha = "abcdefghijklmnopqrstuvwxyz";

            foreach (char c in input)
            {
                int index = alpha.IndexOf(c);
                if (index == -1 )
                {
                    if (char.IsUpper(c))
                    {
                        char c2 = char.ToLower(c);
                        index = alpha.IndexOf(c2);
                        index += charsToShift;
                        c2 = alpha[index];
                        c2 = char.ToUpper(c2);
                        output += c2;
                    }
                    else 
                        output += c;
                }
                else
                {
                    index += charsToShift;       // find the index of char in alphabet and add
                    index = index % 26;
                    output += alpha[index];      // Concatenate to output the char. from alpha at (new) index
                }              
            }                         
            return output;
        }

        private string SubCypher(string input, string charsToSub)       // EXTRA CREDIT. input = what's the string you want to encode, charsToSub = what's the code you want to use.
        {
            string output = "";
            // Two string variables
            // EC: cool user interface, let user pick code

            // for each char in input 
            // index = index of char in alpha
            // output += char at same index in "charsToSub"

            return output;
        }

        private void transformButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            switchCaseTextBox.Text = SwitchCase(input);
            reverseTextBox.Text = Reverse(input);
            pigLatinTextBox.Text = PigSentence(input);
            shiftTextBox.Text = ShiftCypher(input, 4);

        }
    }
}
