using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class CheeseGraterOfPeace : Item
    {
        public CheeseGraterOfPeace() : base("Cheese Grater of Peace", 400) 
        {
            this.hands = 1;
            this.description = "+3 Bonus. Usable by Cleric only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
