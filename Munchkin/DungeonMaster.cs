using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin
{
    class DungeonMaster
    {
        private Deck deck = new Deck();
        private List<Player> players;
        private int player_index = 0;
        private static DungeonMaster instance;

        public static DungeonMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DungeonMaster();
                }
                return instance;
            }
        }

        private DungeonMaster(){}

        public void Begin(List<Player> players)
        {
            this.players = players;
            while (!IsGameOver())
            {
                new CurrentTurn(NextPlayer());
            }
        }

        public bool IsGameOver()
        {
            return false;
        }

        public Deck Deck
        {
            get{return deck;}
        }

        private Player NextPlayer()
        {
            player_index = player_index == (players.Count - 1) ? 0 : player_index++;
            return players[player_index];
        }
    }
}
