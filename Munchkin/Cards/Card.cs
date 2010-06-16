using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards
{
    abstract class Card
    {
        private bool face_down = true;
        private string name;
        private Player owner = null;

        public Card(string name)
        {
            this.name = name;
        }

        public void PickUp() { }
        public void Discard() { }

        public bool IsFaceDown
        {
            get { return face_down; } 
        }
    }
}
