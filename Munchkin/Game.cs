using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin
{
    class Game
    {
        static void Main(string[] args)
        {
            List<Player> players = InitPlayers(args);
            DungeonMaster.Instance.Begin(players);
        }

        private static List<Player> InitPlayers(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
