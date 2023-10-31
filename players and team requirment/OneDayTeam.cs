using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace players_and_team_requirment
{
    public class OneDayTeam : ITeam
    {
        private List<Player> players = new List<Player>();

        public string AddPlayer(int playerId, string name, int age)
        {
            if (players.Count < 11)
            {
                Player newPlayer = new Player { PlayerId = playerId, Name = name, Age = age };
                players.Add(newPlayer);
                return $"Player {name} added to the team.";
            }
            else
            {
                return "The team is already full. Cannot add more players.";
            }
        }

        public string RemovePlayer(int playerId)
        {
            Player playerToRemove = players.Find(player => player.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                return $"Player {playerToRemove.Name} removed from the team.";
            }
            else
            {
                return "Player not found in the team.";
            }
        }

        public string GetPlayerById(int playerId)
        {
            Player player = players.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                return $"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}";
            }
            else
            {
                return "Player not found in the team.";
            }
        }

        public string GetPlayerByName(string playerName)
        {
            Player player = players.Find(p => p.Name == playerName);
            if (player != null)
            {
                return $"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}";
            }
            else
            {
                return "Player not found in the team.";
            }
        }

        public string GetAllPlayers()
        {
            if (players.Count > 0)
            {
                string playerList = "";
                foreach (Player player in players)
                {
                    playerList += $"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}\n";
                }
                return playerList;
            }
            else
            {
                return "No players in the team.";
            }
        }
    }
}

