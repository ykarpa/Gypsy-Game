using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gypsy_Game
{
    public class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {
            Hand.Add(card);
        }

        public void ClearHand()
        {
            Hand.Clear();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
