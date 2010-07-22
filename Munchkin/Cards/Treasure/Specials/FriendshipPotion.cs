using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure.Specials
{
    class FriendshipPotion : Special
    {
        public FriendshipPotion() : base("Friendship Potion") 
        {
            this.description = "Play during any combat. Discard all monsters in the combat. No treasure is gained. Usable once only.";
            this.value = 200;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
