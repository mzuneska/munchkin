using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class ElectricRadioactiveAcidPotion : Card
    {
        public ElectricRadioactiveAcidPotion() : base("Electric Radioactive Acid Potion") 
        {
            this.description = "Use during any combat. +5 to either side. Usable once only.";
            this.value = 200;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
