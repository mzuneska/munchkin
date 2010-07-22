using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class Hireling : Special
    {
        public Hireling() : base("Hireling")
        {
            this.description = "Follows you around and carries things for you. Allows you to carry and use one extra Big item. Will not fight for you! Keep this card in front of you, with your treasures.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
