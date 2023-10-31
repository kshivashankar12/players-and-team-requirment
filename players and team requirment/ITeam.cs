using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace players_and_team_requirment
{
    public interface ITeam
    {
        string AddPlayer(int playerId, string name, int age);
        string RemovePlayer(int playerId);
        string GetPlayerById(int playerId);
        string GetPlayerByName(string playerName);
        string GetAllPlayers();
    }
}
