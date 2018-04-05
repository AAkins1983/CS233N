using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Your RCustomer and WCustomer classes look good. I'm not sure why 
 * GetDisplayText isn't working for you. I don't see any test code 
 * here. Did you do some? Can you show it to me so I can add some 
 * points here? In BJHand - you don't need the 2 instance variables 
 * for score but you do need a local variable for score inside the 
 * Score property getter. - in IsBusted, call Score in the condition 
 * of the if statement rather than referring to the instance variable.
 * Otherwise, you're close. If you need help with this to finish lab 8,
 * come and find me tomorrow!*/

namespace CardClassLibrary
{
    public class BJHand : Hand
    {
        public BJHand()
        { }

        public int Score()
        {
            int score = 0;

            foreach (Card c in cards)
            {
                if (c.IsFaceCard())
                    score += 10;
                else
                    score += c.Value;
            }

            if (HasAce() && score <= 11)
                score += 10;
            return score;        
        }

        public bool HasAce()
        {
            /*foreach (Card c in cards)
            {
                if (c.Value == 1)
                    return true;
            }
            return false;*/

            return HasCard(1);
        }

        public bool IsBusted()
        {
            if (Score() > 21)
                return true;              
            else
                return false;
        }
    }
}
