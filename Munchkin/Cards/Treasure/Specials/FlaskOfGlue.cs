using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class FlaskOfGlue : Special
    {
        public FlaskOfGlue() : base("Flask of Glue")
        {
            this.description = "Use when someone successfully escapes a combat for any reason. They must re-roll their escape (even if it was automatic the first time). Usable once only.";
            this.value = 100;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
