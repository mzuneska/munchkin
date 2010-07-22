using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class MagicMissile : Card
    {
        public MagicMissile() : base("Magic Missile") 
        {
            this.description = "Use during any combat. +5 to either side. Usable once only.";
            this.value = 300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
