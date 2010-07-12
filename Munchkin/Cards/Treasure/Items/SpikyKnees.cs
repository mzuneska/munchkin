using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class SpikyKnees : Item
    {
        public SpikyKnees() : base("Spiky Knees", 200) 
        {
            this.description = "+1 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
