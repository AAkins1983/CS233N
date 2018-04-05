using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            int index = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, suit));
                    index++;
                }
            }
        }

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }
        public void Shuffle()
        {
            Random randomNumberGenerator = new Random();

            for (int index = 0; index <= 51; index++)
            {
                int rndIndex = randomNumberGenerator.Next(0, 52);
                Card temp = cards[index];
                cards[index] = cards[rndIndex];
                cards[rndIndex] = temp;
            }
        }

        public Card Deal()
        {
            Card c1 = cards[0];
            cards.RemoveAt(0);
            return c1;
        }


    }
}
