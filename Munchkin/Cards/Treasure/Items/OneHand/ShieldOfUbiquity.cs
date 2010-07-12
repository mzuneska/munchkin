using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class ShieldOfUbiquity : Item
    {
        public ShieldOfUbiquity() : base("Shielf of Ubiquity", 600) 
        {
            this.big = true;
            this.hands = 1;
            this.description = "+4 Bonus. Usable by Warrior only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
