using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class WandOfDowsing : Special
    {
        public WandOfDowsing() : base("Wand of Dowsing") 
        {
            this.description = "Go through the discards to find any one card you want. Take that card and discard this one.";
            this.value = 1100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
