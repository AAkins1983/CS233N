using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class BJHand : Hand
    {
        public BJHand()
        { }

        int score = 0;
        int Score = 0;

        public int Score()
        {
            foreach (Card c in cards)
            {
                if (c.IsFaceCard())
                    score += 10;
                else
                    score += c.Value;
            }

            if (HasAce && score <= 11)
                score += 10;
        }

        public bool HasAce()
        {
            foreach (Card c in cards)
            {
                if (c.Value == 1)
                    return true;
            }
            return false;
        }

        public bool IsBusted()
        {
            if (score > 21)
                return true;                
        }
    }
}

