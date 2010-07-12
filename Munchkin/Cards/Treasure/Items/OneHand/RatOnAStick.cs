using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class RatOnAStick : Item
    {
        public RatOnAStick() : base("Rat on a Stick", 0) 
        {
            this.hands = 1;
            this.description = "Discard for automatic escape from any monster of level 8 or below.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
