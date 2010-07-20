using System;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure
{
    abstract class GoUpALevel : Card
    {
        public GoUpALevel(string name) : base(name)
        {
            this.description = "Go Up a Level";
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }
    }
}
