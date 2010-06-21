using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Munchkin.Cards;

namespace Munchkin
{
    class Deck
    {
        private List<Card> treasure_cards;
        private List<Card> door_cards;
        private List<Card> discarded_treasure_cards;
        private List<Card> discarded_door_cards;
        private List<Card> out_of_play_cards;

        public Deck()
        {
            ShuffleCards();
        }

        public void DiscardCard(Card card)
        {

        }

        public void TakeTreasureCard(CardFacing card_facing)
        {

        }

        public void TakeDoorCard(CardFacing card_facing)
        {

        }

        public void AnnihilateCard(Card card)
        {

        }

        private void ShuffleCards() { }

        public enum CardFacing
        {
            Up,
            Down
        }
    }
}
