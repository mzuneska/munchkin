using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Headgear
{
    class HornyHelmet : Item
    {
        public HornyHelmet() : base("Horny Helmet", 600)
        {
            this.headgear = true;
            this.description = "+1 Bonus (+3 Bonus for Elves)";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
