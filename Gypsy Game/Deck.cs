using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gypsy_Game
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card Draw()
        {
            // Remove and return the top card from the deck
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public override string ToString()
        {
            return string.Join("\n", cards);
        }
    }
}
