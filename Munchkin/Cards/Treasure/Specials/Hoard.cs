using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class Hoard : Special
    {
        public Hoard() : base("Hoard") 
        {
            this.description = "Draw 3 more treasure cards immediately. They are face-down if you drew this card face-down; otherwise, they are face-up.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
