﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class BroadSword : Item
    {
        public BroadSword() : base("Broad Sword", 400) 
        {
            this.hands = 1;
            this.description = "+3 Bonus. Usable by Female Players Only (or sex-changed males).";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
