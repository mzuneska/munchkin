using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class Doppleganger : Special
    {
        public Doppleganger() : base("Doppleganger") 
        {
            this.description = "Summons your exact duplicate, who fights besides you, so you double your effectice Level and bonuses. You may only use the Doppleganger if you are the only player in the combat. Usable once only.";
            this.value = 300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
