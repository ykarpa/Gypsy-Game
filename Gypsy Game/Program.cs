using System;

namespace Gypsy_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new List<string> { "Юра", "Павло", "Ярослава" });

            Deck deck = new Deck();
            deck.Shuffle();
            Console.WriteLine(deck);
        }
    }
}
