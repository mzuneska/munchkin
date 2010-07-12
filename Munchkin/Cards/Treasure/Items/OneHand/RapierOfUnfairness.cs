using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class RapierOfUnfairness : Item
    {
        public RapierOfUnfairness() : base("Rapier of Unfairness", 600) 
        {
            this.hands = 1;
            this.description = "+3 Bonus. Usable by Elf only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
