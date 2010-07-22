using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class PotionOfIdioticBravery : Card
    {
        public PotionOfIdioticBravery() : base("Potion of Idiotic Bravery") 
        {
            this.description = "Use during any Combat. +2 to either side. Usable once only.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
