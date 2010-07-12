using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Footgear
{
    class SandalsOfProtection : Item
    {
        public SandalsOfProtection() : base("Sandals of Protection", 700) 
        {
            this.footgear = true;
            this.description = "Curse cards which you draw when kicking down a door have no effect. (Curses cast by other players will still affect you.)";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
