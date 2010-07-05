using System;

namespace Munchkin.Lib.Actions
{
    class KillPlayer : IAction
    {
        private Player player;

        public KillPlayer(Player player) 
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Die();
        }

    }
}
