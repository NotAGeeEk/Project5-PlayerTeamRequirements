using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayerAndTeamRequirements
{
   
    class CricketTeam
    {
        private List<Player> players = new List<Player>();

        public bool AddPlayer(Player player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                return true;
            }
            return false;
        }

        public bool RemovePlayer(int playerId)
        {
            Player player = players.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                players.Remove(player);
                return true;
            }
            return false;
        }

        public Player GetPlayerById(int playerId)
        {
            return players.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return players.Find(p => p.Name == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return players;
        }
    }
}
