using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class WishingRing : Special
    {
        public WishingRing() : base("Wishing Ring") 
        {
            //there are two of these
            this.description = "Cancels any curse. Play at any time. Usable once only.";
            this.value = 500;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
