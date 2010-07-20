using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.GoUpALevels
{
    class KillTheHireling : GoUpALevel
    {
        public KillTheHireling() : base("Kill the Hireling")
        {
            this.description = "Go up a level. You can use this card only if the Hireling is in play (no matter who owns him). Discard the Hireling.";      
        }
    }
}
