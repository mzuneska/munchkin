using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class GentlemensClub : Item
    {
        public GentlemensClub() : base("Gentlemen's Club", 400) 
        {
            this.hands = 1;
            this.description = "+3 Bonus. Usable by Male Players Only (or sex-changed females).";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
