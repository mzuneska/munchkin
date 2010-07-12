using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Footgear
{
    class BootsOfRunningReallyFast : Item
    {
        public BootsOfRunningReallyFast() : base("Boots of Running Really Fast", 400) 
        {
            this.footgear = true;
            this.description = "Gives you +2 to Run Away.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
