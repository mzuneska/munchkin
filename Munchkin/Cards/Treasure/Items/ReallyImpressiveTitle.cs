using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class ReallyImpressiveTitle : Item
    {
        public ReallyImpressiveTitle() : base("Really Impressive Title", 0) 
        {
            this.description = "+3 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
