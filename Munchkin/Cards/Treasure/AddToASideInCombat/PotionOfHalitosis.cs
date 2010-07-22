using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.AddToASideInCombat
{
    class PotionOfHalitosis : Card
    {
        public PotionOfHalitosis() : base("Potion of Halitosis") 
        {
            this.description = "Use during any combat. +2 to either side, or instantly kills Floating Nose. Usable once only.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
