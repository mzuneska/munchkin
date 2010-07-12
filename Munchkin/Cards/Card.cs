using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards
{
    abstract class Card
    {
        protected bool face_down = true;
        protected string name;
        protected Player owner = null;
        protected string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Card(string name)
        {
            this.name = name;
        }

        public void PickUp() 
        {
            throw new NotImplementedException();
        }

        public void Discard() 
        {
            throw new NotImplementedException();
        }

        public abstract void Play();

        public bool IsFaceDown
        {
            get { return face_down; } 
        }

        public enum Genre
        {
            Door,
            Treasure
        }
    }
}
