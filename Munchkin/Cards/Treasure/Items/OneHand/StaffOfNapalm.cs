using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class StaffOfNapalm : Item
    {
        public StaffOfNapalm() : base("Staff of Napalm", 800) 
        {
            this.hands = 1;
            this.flaming = true;
            this.description = "+5 Bonus. Usable by Wizard only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
