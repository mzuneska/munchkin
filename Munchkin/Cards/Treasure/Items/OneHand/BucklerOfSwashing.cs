using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class BucklerOfSwashing : Item
    {
        public BucklerOfSwashing() : base("Buckler of Swashing", 400) 
        {
            this.hands = 1;
            this.description = "+2 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
