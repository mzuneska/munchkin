using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class PantyhoseOfGiantStrength : Item
    {
        public PantyhoseOfGiantStrength() : base("Pantyhose of Giant Strength", 600) 
        {
            this.description = "+3 Bonus. Not Usable by Warrior";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
