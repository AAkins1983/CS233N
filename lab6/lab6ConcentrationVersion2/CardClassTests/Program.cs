using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardClassLibrary;

namespace CardClassTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();
            TestDeckMethods();
            TestHandMethods();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestHandMethods()
        {
            Hand h = new Hand();
            Card c1 = new Card(1, 4);
            Card c2 = new Card(12, 3);
            Card c3 = new Card(2, 2);

            Console.WriteLine("Testing Hand Methods");
            Console.WriteLine("Testing NumCards. Expecting 0. " + h.Count());
            h.Add(c1);
            h.Add(c2);
            Console.WriteLine("Adding 2 cards. Expecting Ace of Spades and Queen of Hearts. " + c1 + " " + c2);
            Console.WriteLine("Testing NumCards. Expecting 2 " + h.Count());
            Console.WriteLine("Testing IndexOf(Card). Expecting 0 1. " + h.IndexOf(c1) + " " + h.IndexOf(c2));
            Console.WriteLine("Testing IndexOf(value). Expecting 0 1. " + h.IndexOf(1) + " " + h.IndexOf(12));
            Console.WriteLine("Testing IndexOf(value, suit). Expecting 0 1. " + h.IndexOf(1, 4) + " " + h.IndexOf(12, 3));
            Console.WriteLine("Testing HasCard(Card). Expecting True False. " + h.HasCard(c1) + " " + h.HasCard(c3));
            Console.WriteLine("Testing HasCard(value). Expecting True False. " + h.HasCard(1) + " " + h.HasCard(2));
            Console.WriteLine("Testing HasCard(value, suit). Expecting True False. " + h.HasCard(1, 4) + " " + h.HasCard(2, 2));
            h.Discard(0);
            Console.WriteLine("Testing Discard. Expect 1. " + h.NumCards);
        }

        static void TestDeckMethods()
        {
            Deck d1 = new Deck();

            Console.WriteLine("Testing Deck methods");
            Console.WriteLine("Testing NumCards. Expecting 52 " + d1.Count());
            Console.WriteLine("Testing IsEmpty. Expecting false " + d1.IsEmpty());
            Console.WriteLine("Testing Deal. Expect Ace of Clubs. " + d1.Deal());
            d1.Shuffle();
            Console.WriteLine("Testing Shuffle. Should display a new card. " + d1.Deal());
            Console.WriteLine("Here is my deck." + d1);  
        }

        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(13, 4);

            Console.WriteLine("Testing the constructors");
            Console.WriteLine("Default constructor. Expecting Ace of Hearts. " + c1);
            Console.WriteLine("Overloaded constructor. Expecting King of Spades. " + c2);
        }
    }
}
