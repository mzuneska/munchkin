using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.OneHand
{
    class DaggerOfTreachery : Item
    {
        public DaggerOfTreachery() : base("Dagger of Treachery", 400) 
        {
            this.hands = 1;
            this.description = "+3 Bonus. Usable by Thief only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
