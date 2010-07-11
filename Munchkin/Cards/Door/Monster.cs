using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin.Cards.Door
{
    abstract class Monster : Card
    {
        private int level;

        protected int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int levels_gained = 1;

        protected int LevelsGained
        {
            get { return levels_gained; }
            set { levels_gained = value; }
        }
        private int treasures_won = 1;

        protected int TreasuresWon
        {
            get { return treasures_won; }
            set { treasures_won = value; }
        }
        private bool is_undead = false;

        protected bool IsUndead
        {
            get { return is_undead; }
            set { is_undead = value; }
        }
        
        private string bad_stuff_description;

        protected string BadStuffDescription
        {
            get { return bad_stuff_description; }
            set { bad_stuff_description = value; }
        }

        public Monster(string name) : base(name) { }

        public virtual void BadStuff() {}
    }
}
