﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class FreezingExplosivePotion : Card
    {
        public FreezingExplosivePotion() : base("Freezing Explosive Potion") 
        {
            this.description = "Use during any combat. +3 to either side. Usable once only.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
