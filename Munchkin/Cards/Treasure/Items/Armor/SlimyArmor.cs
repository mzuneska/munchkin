using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Armor
{
    class SlimyArmor : Item
    {
        public SlimyArmor() : base("Slimy Armor", 200) 
        {
            this.armor = true;
            this.description = " +1 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
