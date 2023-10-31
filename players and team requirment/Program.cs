using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace players_and_team_requirment
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1: Add Player");
                Console.WriteLine("2: Remove Player by Id");
                Console.WriteLine("3: Get Player By Id");
                Console.WriteLine("4: Get Player by Name");
                Console.WriteLine("5: Get All Players");
                Console.WriteLine("6: Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("12:");
                            int playerId = int.Parse(Console.ReadLine());
                            Console.WriteLine("shiva:");
                            string playerName = Console.ReadLine();
                            Console.WriteLine("shiva:");
                            int playerAge = int.Parse(Console.ReadLine());
                            Console.WriteLine(team.AddPlayer(playerId, playerName, playerAge));
                            break;
                        case 2:
                            Console.WriteLine("Enter Player ID to remove:");
                            int idToRemove = int.Parse(Console.ReadLine());
                            Console.WriteLine(team.RemovePlayer(idToRemove));
                            break;
                        case 3:
                            Console.WriteLine("Enter Player ID to get:");
                            int idToGet = int.Parse(Console.ReadLine());
                            Console.WriteLine(team.GetPlayerById(idToGet));
                            break;
                        case 4:
                            Console.WriteLine("Enter Player Name to get:");
                            string nameToGet = Console.ReadLine();
                            Console.WriteLine(team.GetPlayerByName(nameToGet));
                            break;
                        case 5:
                            Console.WriteLine(team.GetAllPlayers());
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}

