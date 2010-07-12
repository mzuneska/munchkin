using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.TwoHands
{
    class ElevenFootPole : Item
    {
        public ElevenFootPole() : base("Eleven-Foot Pole", 200) 
        {
            this.hands = 2;
            this.description = "+1 Bonus";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
