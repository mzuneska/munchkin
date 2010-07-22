using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class LoadedDie : Special
    {
        public LoadedDie() : base("Loaded Die") 
        {
            this.description = "Play after you roll the die, for any reason. Turn the die so the number of your choice is on top. That's your roll. Usable once only.";
            this.value = 300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
