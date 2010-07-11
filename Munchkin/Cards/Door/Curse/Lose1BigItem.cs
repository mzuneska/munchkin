using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Door.Curse
{
    class Lose1BigItem : Card
    {
        public Lose1BigItem() : base("Lose 1 Big Item")
        {
            this.description = "Choose one big item to discard";
        }

        public void Curse() { }
    }
}
