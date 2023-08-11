using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayerAndTeamRequirements
{
    class CricketTeamConsoleUI
    {
        private CricketTeam cricketTeam = new CricketTeam();

        public void Run()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Remove Player");
                Console.WriteLine("3. Get Player by ID");
                Console.WriteLine("4. Get Player by Name");
                Console.WriteLine("5. Get All Players");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPlayer();
                        break;
                    case 2:
                        RemovePlayer();
                        break;
                    case 3:
                        GetPlayerById();
                        break;
                    case 4:
                        GetPlayerByName();
                        break;
                    case 5:
                        GetAllPlayers();
                        break;
                }
            } while (choice != 0);
        }

        private void AddPlayer()
        {
            Player player = new Player();
            Console.Write("Enter Player ID: ");
            player.PlayerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Name: ");
            player.Name = Console.ReadLine();
            Console.Write("Enter Player Age: ");
            player.Age = Convert.ToInt32(Console.ReadLine());

            bool added = cricketTeam.AddPlayer(player);

            if (added)
            {
                Console.WriteLine("Player added successfully.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players.");
            }
        }

        private void RemovePlayer()
        {
            Console.Write("Enter Player ID to remove: ");
            int playerId = Convert.ToInt32(Console.ReadLine());

            bool removed = cricketTeam.RemovePlayer(playerId);

            if (removed)
            {
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        private void GetPlayerById()
        {
            Console.Write("Enter Player ID: ");
            int playerId = Convert.ToInt32(Console.ReadLine());

            Player player = cricketTeam.GetPlayerById(playerId);

            if (player != null)
            {
                Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        private void GetPlayerByName()
        {
            Console.Write("Enter Player Name: ");
            string playerName = Console.ReadLine();

            Player player = cricketTeam.GetPlayerByName(playerName);

            if (player != null)
            {
                Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        private void GetAllPlayers()
        {
            List<Player> players = cricketTeam.GetAllPlayers();
            foreach (Player player in players)
            {
                Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}");
            }
        }
    }
}


