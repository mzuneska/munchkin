using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class TubaOfCharm : Item
    {
        public TubaOfCharm() : base("Tuba of Charm", 300) 
        {
            this.big = true;
            this.hands = 1;
            this.description = "Gives you +1 to Run Away.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
