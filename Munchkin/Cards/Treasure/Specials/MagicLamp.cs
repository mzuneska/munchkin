using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class MagicLamp : Special
    {
        public MagicLamp() : base("Magic Lamp") 
        {
            // there are two of these cards
            this.description = "You may use the Lamp only on your own turn. It summons a genie who makes a single monster vanish, even if you had already failed your Run Away roll and it was about to catch you. If it was the only monster you were facing, you may take its treasure, but you don't gain a level. Usable once only.";
            this.value = 500;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
