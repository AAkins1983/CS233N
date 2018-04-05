using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Card
    {
        private int suit;
        private int value;

        // static belongs to class as whole not individual object. Starts with "" because it starts with 1, ace is 1
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };

        public Card()       // default constructor
        {
            value = 1;      // 1 = Ace
            suit = 3;       // 3 = 
        }

        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;     // left hand side = instance variable right hand side = context sensitive keyword "value"
            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                this.suit = value;     // left hand side = instance variable right hand side = context sensitive keyword "value"
            }
        }

        public bool IsFaceCard()
        {
            if (value > 10)
                return true;
            else
                return false;
        }

        public bool IsAce()
        {
            if (value == 1)
                return true;
            else
                return false;
        }

        public bool IsRed()
        {
            if (suit == 2 || suit == 3)
                return true;
            else
                return false;
        }

        public bool IsBlack()
        {
            if (suit == 1 || suit == 4)
                return true;
            else
                return false;
        }

        public bool IsClub()
        {
            if (suit == 1)
                return true;
            else
                return false;
        }

        public bool IsDiamond()
        {
            if (suit == 2)
                return true;
            else
                return false;
        }

        public bool IsHeart()
        {
            if (suit == 3)
                return true;
            else
                return false;
        }

        public bool IsSpade()
        {
            if (suit == 4)
                return true;
            else
                return false;
        }

        public string Filename
        {
            get
            {
                return "card" + values[value].Substring(0, 1) + suits[suit].Substring(0, 1) + ".jpg";
            }
        }

        public bool HasMatchingValue(Card otherCard)
        {
            if (this.Value == otherCard.Value)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return values[value] + " of " + suits[suit];    // go to array and get value out of values, go to array and suit out of suits and concatenate
        }
    }
}
