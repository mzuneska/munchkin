using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class LimburgerAndAnchovySandwich : Item
    {
        public LimburgerAndAnchovySandwich() : base("Limburger and Anchovy Sandwich", 400) 
        {
            this.description = "+3 Bonus. Useable by Halfing Only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
