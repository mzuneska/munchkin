﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class SleepPotion : Card
    {
        public SleepPotion() : base("Sleep Potion") 
        {
            this.description = "Play during any combat. +2 to either side. Usable once only.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
