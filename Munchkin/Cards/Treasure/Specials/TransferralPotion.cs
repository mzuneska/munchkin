using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class TransferralPotion : Special
    {
        public TransferralPotion() : base("Transferral Potion") 
        {
            this.description = "Play during any combat. Any other player (your choice) fight the monster(s), may ask for help normally, and gets the treasure and levels if he wins. The original player then resumes his turn, and may loot the room whether the combat was won or lost. Usable once only.";
            this.value = 300;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
