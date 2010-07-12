using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.TwoHands
{
    class BowWithRibbons : Item
    {
        public BowWithRibbons() : base("Bow With Ribbons", 800) 
        {
            this.hands = 2;
            this.description = "+4 Bonus. Usable by Elf only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
