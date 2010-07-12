using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class SingingAndDancingSword : Item
    {
        public SingingAndDancingSword() : base("Singing & Dancing Sword", 400) 
        {
            this.description = "+2 Bonus. Not useable by Thief.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
