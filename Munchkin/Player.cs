using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Munchkin.Cards;
using Munchkin.Cards.Treasure.Items;

namespace Munchkin
{
    class Player
    {
        private Gender sex;
        private int level = 1;
        private string name;
        private int big_items = 1;
        private bool is_in_combat = false;
        private bool is_current_turn = false;

        private List<Card> hand;
        private List<Item> carried;

        private List<Item> hands;
        private Item head_gear;
        private Item armor;
        private Item foot_gear;

        public Player(Gender sex, string name) 
        {
            this.sex = sex;
            Name = name;
        }

        public int Level { get { return level; } private set { level = value; } }
        public Gender Sex { get { return sex; }}
        public string Name { get { return name; } set { name = value; } }

        public Item HeadGear { get { return head_gear; } set { head_gear = value; } }
        public Item Armor { get { return armor; } set { armor = value; } }
        public Item FootGear { get { return foot_gear; } set { foot_gear = value; } }

        public int Strength()
        {
            return Level;
        }

        public int LevelUp()
        {
            Level++;
            return Level;
        }

        public int LevelDown()
        {
            Level--;
            return Level;
        }

        public Gender ChangeSex()
        {
            sex = (sex == Gender.Male) ? Gender.Female : Gender.Male;
            return sex;
        }

        public void DiscardHand()
        {
            throw new NotImplementedException();
        }

        public void BeginTurn()
        {
            this.is_current_turn = true;
        }

        public void EndTurn()
        {
            this.is_current_turn = false;
        }

        public void AddToHand(Card card)
        {
            throw new NotImplementedException();
        }

        enum Gender
        {
            Male,
            Female
        }
    }
}
