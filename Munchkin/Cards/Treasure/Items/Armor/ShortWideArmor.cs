using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Armor
{
    class ShortWideArmor : Item
    {
        public ShortWideArmor() : base("Short Wide Armor", 400) 
        {
            this.armor = true;
            this.description = "+3 Bonus. Usable by Dwarf only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
