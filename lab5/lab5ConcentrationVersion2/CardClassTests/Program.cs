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
            TestAddCard();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(13, 4);

            Console.WriteLine("Testing the constructors");
            Console.WriteLine("Default constructor. Expecting Ace of Hearts. " + c1);
            Console.WriteLine("Overloaded constructor. Expecting King of Spades. " + c2);
        }

        static void TestAddCard()
        {

        }
    }
}
