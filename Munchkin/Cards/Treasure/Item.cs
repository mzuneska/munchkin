using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Treasure
{
    abstract class Item : Card
    {
        protected int value = 0;
        protected int hands = 0;
        protected bool flaming = false;
        protected bool big = false;
        protected bool headgear = false;
        protected bool footgear = false;
        protected bool armor = false;

        public int Value
        {
            get { return this.value; }
        }

        public int Hands
        {
            get { return this.hands; }
        }

        public bool Flaming
        {
            get { return this.flaming; }
        }

        public bool Big
        {
            get { return this.big; }
        }

        public bool Headgear
        {
            get { return this.headgear; }
        }

        public bool Footgear
        {
            get { return this.footgear; }
        }

        public bool Armor
        {
            get { return armor; }
        }

        public Item(string name, int value) : base(name) 
        {
            this.value = value;
        }
    }
}
