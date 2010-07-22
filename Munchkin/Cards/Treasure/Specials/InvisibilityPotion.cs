using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class InvisibilityPotion : Special
    {
        public InvisibilityPotion() : base("Invisibility Potion") 
        {
            this.description = "Discard when escape roll fails. You escape automatically. Usable once only.";
            this.value = 200;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
