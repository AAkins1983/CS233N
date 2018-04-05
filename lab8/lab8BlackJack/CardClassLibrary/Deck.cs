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

        public int Count()
        {
            int i = 0;
            foreach (Card count in cards)
            {
                i++;
            }
            return i;
        }

        public void Shuffle()
        {
            Random randomNumberGenerator = new Random();

            for (int index = 0; index < cards.Count ; index++)
            {
                int rndIndex = randomNumberGenerator.Next(0, cards.Count);
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

        public bool IsEmpty()
        {
            if (cards.Count() == 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            string output = "";
            foreach(Card c in cards)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
    }
}
