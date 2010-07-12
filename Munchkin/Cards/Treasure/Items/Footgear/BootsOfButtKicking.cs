using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Footgear
{
    class BootsOfButtKicking : Item
    {
        public BootsOfButtKicking() : base("Boots of Butt-Kicking", 400)
        {
            this.footgear = true;
            this.description = "+2 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
