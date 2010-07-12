using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class Stepladder : Item
    {
        public Stepladder() : base("Stepladder", 400)
        {
            this.big = true;
            this.description = "+3 Bonus. Usable by Halfling only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

    }
}
