using System;

namespace Gypsy_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine(deck);
        }
    }
}
