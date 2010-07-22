using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class NastyTastingSportsDrink : Card
    {
        public NastyTastingSportsDrink() : base("Nasty-Tasting Sports Drink") 
        {
            this.description = "Use during any combat. +2 to either side. Usable once only.";
            this.value = 200;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
