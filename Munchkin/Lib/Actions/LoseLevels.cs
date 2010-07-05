using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Lib.Actions
{
    class LoseLevels : IAction
    {
        private Player player;
        private int levels_to_lose;

        public LoseLevels(Player player, int levels_to_lose)
        {
            this.player = player;
            this.levels_to_lose = levels_to_lose;
        }

        public void Execute()
        {
            for (int i = 0; i < levels_to_lose; i++)
            {
                player.LevelDown;
            }
        }
    }
}
