using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class StealALevel : Special
    {
        public StealALevel() : base("Steal a Level") 
        {
            this.description = "Pick any player to steal a Level from. You go up one. He goes down one.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
