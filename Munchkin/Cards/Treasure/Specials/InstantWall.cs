using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class InstantWall : Special
    {
        public InstantWall() : base("Instant Wall") 
        {
            this.description = "Allows automatic escape, for one or two characters, from any fight. Usable only once.";
            this.value = 300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
