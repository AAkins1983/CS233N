using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TTTForm : Form
    {
        public TTTForm()
        {
            InitializeComponent();
        }

        const string USER_SYMBOL = "X";
        const string COMPUTER_SYMBOL = "O";
        const string EMPTY = "";

        // constants for the 2 diagonals
        const int TOP_LEFT_TO_BOTTOM_RIGHT = 1;
        const int TOP_RIGHT_TO_BOTTOM_LEFT = 2;

        // constants for IsWinner
        const int NONE = -1;
        const int ROW = 1;
        const int COLUMN = 2;
        const int DIAGONAL = 3;

        // This method takes a row and column as parameters and 
        // returns a reference to a label on the form in that position
        private Label GetSquare(int row, int column)
        {
            int labelNumber = row * 3 + column + 1;
            return (Label)(this.Controls["label" + labelNumber.ToString()]);
        }

        // This method does the "reverse" process of GetSquare
        // It takes a label on the form as it's parameter and
        // returns the row and column of that square as output parameters
        private void GetRowAndColumn(Label l, out int row, out int column)
        {
            int position = int.Parse(l.Name.Substring(5));
            row = (position - 1) / 3;
            column = (position - 1) % 3;
        }

        // This method takes a row (in the range of 0 - 2) and returns true if 
        // the row on the form contains 3 Xs or 3 Os.
        // Use it as a model for writing IsColumnWinner
        private bool IsRowWinner(int row)
        {
            Label square = GetSquare(row, 0);
            string symbol = square.Text;
            for (int col = 1; col < 3; col++)
            {
                square = GetSquare(row, col);
                if (symbol == EMPTY || square.Text != symbol)
                    return false;
            }
            return true;
        }

        //* TODO:  finish all of these that return true
        private bool IsAnyRowWinner()
        {
            return true;
        }

        private bool IsColumnWinner(int col)
        {
            return true;
        }

        private bool IsAnyColumnWinner()
        {
            return true;
        }

        private bool IsDiagonal1Winner()
        {
            return true;
        }

        private bool IsDiagonal2Winner()
        {
            return true;
        }

        private bool IsAnyDiagonalWinner()
        {
            return true;
        }

        private bool IsFull()
        {
            return true;
        }

        // This method determines if any row, column or diagonal on the board is a winner.
        // It returns true or false and the output parameters will contain appropriate values
        // when the method returns true.  See constant definitions at top of form.
        private bool IsWinner(out int whichDimension, out int whichOne)
        {
            // rows
            for (int row = 0; row < 3; row++)
            {
                if (IsRowWinner(row))
                {
                    whichDimension = ROW;
                    whichOne = row;
                    return true;
                }
            }
            // columns
            for (int column = 0; column < 3; column++)
            {
                if (IsColumnWinner(column))
                {
                    whichDimension = COLUMN;
                    whichOne = column;
                    return true;
                }
            }
            // diagonals
            if (IsDiagonal1Winner())
            {
                whichDimension = DIAGONAL;
                whichOne = TOP_LEFT_TO_BOTTOM_RIGHT;
                return true;
            }
            if (IsDiagonal2Winner())
            {
                whichDimension = DIAGONAL;
                whichOne = TOP_RIGHT_TO_BOTTOM_LEFT;
                return true;
            }

            // no winner found
            whichDimension = NONE;
            whichOne = NONE;
            return false;
        }

        // I wrote this method to show you how to call IsWinner
        private bool IsTie()
        {
            int winningDimension, winningValue;
            return (IsFull() && !IsWinner(out winningDimension, out winningValue));
        }

        // This method takes an integer in the range 0 - 2 that represents a column
        // as it's parameter and changes the font color of that cell to red.
        private void HighlightColumn(int col)
        {
            for (int row = 0; row < 3; row++)
            {
                Label square = GetSquare(row, col);
                square.Enabled = true;
                square.ForeColor = Color.Red;
            }
        }

        private void HighlightDiagonal(int whichDiagonal)
        {
            if (whichDiagonal == TOP_LEFT_TO_BOTTOM_RIGHT)
                HighlightDiagonal1();
            else
                HighlightDiagonal2();

        }

        //* TODO:  finish the rest of these
        private void HighlightDiagonal1()
        {
        }

        private void HighlightDiagonal2()
        {
        }

        private void HighlightRow(int row)
        {
        }

        //* TODO:  finish this
        private void HighlightWinner(string player, int winningDimension, int winningValue)
        {
            switch (winningDimension)
            {
                case ROW:

                    break;
                case COLUMN:

                    break;
                case DIAGONAL:

                    break;
            }
        }

        //* TODO:  finish these 2
        private void ResetForm()
        {
        }

        private void MakeComputerMove()
        {
        }

        // Setting the enabled property changes the look and feel of the cell.
        // Instead, this code removes the event handler from each square.
        // Use it when someone wins or the board is full to prevent clicking a square.
        private void DisableAllSquares()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Label square = GetSquare(row, col);
                    square.DoubleClick -= new System.EventHandler(this.label_DoubleClick);
                }
            }
        }

        // Inside the click event handler you have a reference to the label that was clicked
        // Use this method (and pass that label as a parameter) to disable just that one square
        private void DisableSquare(Label square)
        {
            square.DoubleClick -= new System.EventHandler(this.label_DoubleClick);
        }

        // You'll need this method to allow the user to start a new game
        private void EnableAllSquares()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Label square = GetSquare(row, col);
                    square.DoubleClick += new System.EventHandler(this.label_DoubleClick);
                }
            }
        }

        //* TODO:  finish this
        private void label_DoubleClick(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;

        }
    }
}
