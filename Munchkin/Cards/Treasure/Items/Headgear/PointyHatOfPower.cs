using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Headgear
{
    class PointyHatOfPower : Item
    {
        public PointyHatOfPower() : base("Pointy Hat of Power", 400)
        {
            this.headgear = true;
            this.description = "+3 Bonus. Usable by Wizard only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
