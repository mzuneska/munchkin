using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Armor
{
    class FlamingArmor : Item
    {
        public FlamingArmor() : base("Flaming Armor", 400) 
        {
            this.armor = true;
            this.flaming = true;
            this.description = "+2 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
