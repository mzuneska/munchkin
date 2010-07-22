using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class PollymorphPotion : Special
    {
        public PollymorphPotion() : base("Pollymorph Potion") 
        {
            this.description = "Use during any combat. Turns any one monster into a parrot, which flies away leaving its treasure behind. Usable only once.";
            this.value = 1300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
