using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Armor
{
    class MithrilArmor : Item
    {
        public MithrilArmor() : base("Mithril Armor", 600) 
        {
            this.big = true;
            this.armor = true;
            this.description = "+3 Bonus. Not usable by Wizard.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
