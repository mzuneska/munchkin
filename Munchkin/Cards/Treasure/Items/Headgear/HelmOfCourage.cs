using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Headgear
{
    class HelmOfCourage : Item
    {
        public HelmOfCourage() : base("Helm of Courage", 200)
        {
            this.headgear = true;
            this.description = "+1 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
