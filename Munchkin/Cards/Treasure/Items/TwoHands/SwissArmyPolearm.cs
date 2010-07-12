using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.TwoHands
{
    class SwissArmyPolearm : Item
    {
        public SwissArmyPolearm() : base("Swiss Army Polearm", 600) 
        {
            this.big = true;
            this.hands = 2;
            this.description = "+4 Bonus. Usable by Human only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
