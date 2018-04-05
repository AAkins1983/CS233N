using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concentration
{
    public partial class boardForm : Form
    {
        public boardForm()
        {
            InitializeComponent();
        }

        #region Instance Variables

        //* ToDo:  you'll need an array of strings named cards, 2 indexes and the number of matches
        //* My array is set up to hold 21 strings and I ignore the 0 element because I named the picture boxes
        //* starting at 1 rather than 0

        const int NOT_PICKED_YET = -1;

        // this is for the timer that displays the elapsed time.  I included it for illustration purposed only.
        private int seconds = 0;
        #endregion

        #region Methods
        //* ToDo:  Write some methods
        // you may need more methods but here's the list that I used
        // this should fill the cards (array of strings) with card file names
        private void FillCards()
        {
            string[] values = { "a", "5", "j", "q", "k" };
            string[] suits = { "c", "d", "h", "s" };
            int index = 1;
            foreach (string value in values)
            {
                foreach (string suit in suits)
                {
                    //* ToDo:  Add a string for the filename of the card
                    // to the array.  The first card, for example, should be
                    // cards[1] = "cardac.jpg";
                    index++;
                }
            }
        }

        //* ToDo:  determines if the 2 cards are a match.  The "value" of the card is in the filename at the 5th char.
        private bool IsMatch(int index1, int index2)
        {
            return true;
        }

        //* ToDo:  shuffles the strings in the cards array.  I'll give you an algorithm in class for this.
        private void ShuffleCards()
        {

        }
        
        // loads the specified card picture box with the filename from the array
        private void LoadCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + cards[i]);
        }

        //* ToDo:  loads an image for the back of a card in the specified card
        private void LoadCardBack(int i)
        {
        }

        //* ToDo:  disables and hides the specified card
        private void HideCard(int i)
        {
        }

        //* ToDo:  disables and hides all cards.  Call HideCard in a loop.
        private void HideAllCards()
        {
        }


        //* ToDo:  disables the specified card
        private void DisableCard(int i)
        {
        }

        //* ToDo:  disables all cards.  Call DisableCard in a loop.
        private void DisableAllCards()
        {
        }

        //* ToDo:  enables and shows all of the cards
        private void ShowAllCards()
        {
        }

        //* ToDo:  enables the cards that are still visible on the board
        private void EnableAllVisibleCards()
        {
        }

        #endregion
        //* ToDo:  finish this
        private void frmBoard_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            lblElapsedTime.Text = seconds.ToString();
            // fill the cards array - you have a method
            // show the back of all cards - you have a method
        }

        // This is only for illustration purposes
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblElapsedTime.Text = seconds.ToString();
        }

        //* ToDo: Finish this.  See pseudocode below.
        private void card_Click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            int cardIndex = int.Parse(card.Name.Substring(4));
            /* if the first card is not picked yet
             *      save the index
             *      load the card image
             *      disable the card so the user can't click the same card twice
             * else (the first card has been picked so this is the second card)
             *      save the index of the second card
             *      load the card image
             *      disable all the cards 
             *      start the flip timer
             * end if
             */
        }

        //* ToDo:  Finish this.  See pseudocode below.
        private void flipTimer_Tick(object sender, EventArgs e)
        {
             /* stop the timer
             *  if there's a match
             *      hide the first card clicked
             *      hide the second card clicked
             *      reset both indexes
             *      increment the number of matches
             *      if the game is over
             *          if the user wants to play again
             *              shuffle the cards
             *              show the card backs and enable all of the cards
             *          else
             *              exit the application?
             *          end if
             *      else
             *          enable all of the cards left on the board
             *      end if
             * else
             *      show the back of the first card clicked
             *      show the back of the second card clicked
             *      reset both indexes
             *      enable all of the cards left on the board
             * end if
             */              
        }
    }
}
