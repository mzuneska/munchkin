﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.TwoHands
{
    class HugeRock : Item
    {
        public HugeRock() : base("Huge Rock", 0) 
        {
            this.big = true;
            this.hands = 2;
            this.description = "+3 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
