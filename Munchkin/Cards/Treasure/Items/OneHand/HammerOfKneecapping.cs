using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class HammerOfKneecapping : Item
    {
        public HammerOfKneecapping() : base("Hammer of Kneecapping", 600) 
        {
            this.hands = 1;
            this.description = "+4 Bonus. Usable by Dwarf only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
