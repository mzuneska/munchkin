using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class MaceOfSharpness : Item
    {
        public MaceOfSharpness() : base("Mace of Sharpness", 600) 
        {
            this.hands = 1;
            this.description = "+4 Bonus. Usable by Cleric only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
