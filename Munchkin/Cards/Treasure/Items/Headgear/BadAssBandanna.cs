using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items.Headgear
{
    class BadAssBandanna : Item
    {
        public BadAssBandanna(string name, int value) : base("Bad-Ass Bandanna", 400)
        {
            this.headgear = true;
            this.description = "+3 Bonus. Usable by Humans only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
