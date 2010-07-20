using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.GoUpALevels
{
    class WhineAtTheGM : GoUpALevel
    {
        public WhineAtTheGM() : base("Whine at the GM")
        {
            this.description = "Go up a level. You can't use this if you are currently the highest-level player, or tied for the highest.";
        }
    }
}
