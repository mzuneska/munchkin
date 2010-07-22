using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class YuppieWater : Card
    {
        public YuppieWater() : base("Yuppie Water") 
        {
            this.description = "Use during any combat. Usable once only, and only to help Elves. +2 to each Elf in the battle.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
