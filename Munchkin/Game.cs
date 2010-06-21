using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Munchkin
{
    class Game
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Console.WriteLine("Enter player name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter player gender (M/F): ");
            string gender = Console.ReadLine();
            players.Add(CreatePlayer(gender, name));

            foreach (Player player in players)
            {
                Console.WriteLine("{0} joins the party as a {1} level 1 Human with no class.", player.Name, player.Sex);
            }

            DungeonMaster.Instance.Begin(players);
        }

        private static Player CreatePlayer(string gender, string name)
        {
            Player.Gender gender_enum = gender.ToUpper().Equals("M") ? Player.Gender.Male : Player.Gender.Female;
            return new Player(gender_enum, name);
        }
    }
}
