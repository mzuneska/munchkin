using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class PrettyBalloons : Card
    {
        public PrettyBalloons() : base("Pretty Balloons") 
        {
            this.description = "Use during any combat, for distraction. +5 to either side. Usable once only.";
            this.value = 0;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
