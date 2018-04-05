using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public Hand() { }

        public bool HasCard(Card searchCard)
        {
            foreach (Card cardInHand in cards)
            {
                if (searchCard.Value == cardInHand.Value && searchCard.Suit == cardInHand.Suit)
                    return true;
            }
            return false;
        }

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card Discard(Card index)
        {
            Card c1 = cards[0];
            cards.RemoveAt(0);
            return c1;
        }
        
    }
}
