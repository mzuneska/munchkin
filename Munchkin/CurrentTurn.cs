using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Munchkin.Cards;

namespace Munchkin
{
    class CurrentTurn
    {
        private Player player;
        private Card door_card;
        private State state = State.PreDoor;
        private DungeonMaster dm = DungeonMaster.Instance;

        public CurrentTurn(Player player)
        {
            this.player = player;
            player.BeginTurn();
            KickDownDoor();
            

        }

        public void KickDownDoor()
        {
            this.state = State.KickDownDoor;
            dm.Deck.TakeDoorCard(Deck.CardFacing.Up);

            /* switch on card type
            Combat(door_card, player);
            Cursed(door_card, player);
            player.AddToHand(door_card);*/
        }

        public bool Combat(Card monster, Player player)
        {
            return true;
        }

        public void Cursed(Card curse, Player player)
        {

        }

        enum State
        {
            PreDoor,
            KickDownDoor,
            ActOnRoom,
            PostRoom,
            Charity
        }
    }
}
