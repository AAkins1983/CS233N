using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardClassLibrary;

namespace BlackJack
{
    public partial class BlackJackForm : Form
    {
        // instance variables outside of event handlers so they can be used everywhere
        private Deck deck;
        private BJHand player, dealer;

        
        public BlackJackForm()
        {
            InitializeComponent();
        }

        private void LoadPlayerHand()
        {
            for (int i = 0; i < player.NumCards; i++)
                LoadPlayerCard(i);
            for (int i = player.NumCards; i < 5; i++)
                HidePlayerCard(i);                      
        }

        private void LoadDealerHand()
        {
            for (int i = 0; i < dealer.NumCards; i++)
                LoadDealerCard(i);
            for (int i = dealer.NumCards; i < 5; i++)
                HideDealerCard(i);
        }

        private void LoadPlayerCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["pCard" + i];
            card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + player.GetCard(i).Filename);
            card.Visible = true;
        }

        private void LoadDealerCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["dCard" + i];
            card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + dealer.GetCard(i).Filename);
            card.Visible = true;
        }

        //* loads an image for the back of a card in the specified card
        private void LoadDealerCardBack(int i)
        {
            PictureBox card = (PictureBox)this.Controls["dCard" + i];
            card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + "black_back.jpg");
        }

        //* disables and hides the specified card - set visible property to false
        private void HidePlayerCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["pCard" + i];
            card.Enabled = false;
            card.Visible = false;
        }

        private void HideDealerCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["dCard" + i];
            card.Enabled = false;
            card.Visible = false;
        }
        private void newHandButton_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            player = new BJHand();
            dealer = new BJHand();

            deck.Shuffle();
            player.Add(deck.Deal());    // deal a card and add to player's hand
            dealer.Add(deck.Deal());
            player.Add(deck.Deal());
            dealer.Add(deck.Deal());

            LoadPlayerHand();
            LoadDealerHand();
        }


        private void hitButton_Click(object sender, EventArgs e)
        {
            player.Add(deck.Deal());
            LoadPlayerHand();
            PlayerScore();

            if (player.IsBusted())
                MessageBox.Show("BOOHOO, you bust!");
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            while (dealer.Score() <= 17)
            {
                dealer.Add(deck.Deal());
            }
            LoadDealerHand();
            DealerScore();

            if (dealer.IsBusted())
                MessageBox.Show("BOOHOO, you bust!");
        }

        public void PlayerScore()
        {
            int score = 0;
            score = player.Score();
            pScoreLabel.Text = score.ToString();
        }

        public void DealerScore()
        {
            int score = 0;
            score = dealer.Score();
            dScoreLabel.Text = score.ToString();
        }

        private void BlackJackForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void dScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
