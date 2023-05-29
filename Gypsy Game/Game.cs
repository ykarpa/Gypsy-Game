using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gypsy_Game
{
    public class Game
    {
        private List<Player> players;
        private Deck deck;

        public Game(List<string> playerNames)
        {
            players = new List<Player>();
            deck = new Deck();

            foreach (var playerName in playerNames)
            {
                players.Add(new Player(playerName));
            }
        }

        public void Start()
        {
            deck.Shuffle();
        }
    }
}
