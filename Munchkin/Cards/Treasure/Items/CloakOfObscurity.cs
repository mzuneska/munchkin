using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Items
{
    class CloakOfObscurity : Item
    {
        public CloakOfObscurity() : base("Cloak of Obscurity", 600) 
        {
            this.description = "+4 Bonus. Usable by Thief only.";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
