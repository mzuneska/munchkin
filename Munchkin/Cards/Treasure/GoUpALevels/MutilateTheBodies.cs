using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.GoUpALevels
{
    class MutilateTheBodies : GoUpALevel
    {
        public MutilateTheBodies() : base("Mutilate The Bodies") 
        {
            this.description = "Go up a level. This card can only be played after combat, but it does not have to be your combat.";
        }
    }
}
