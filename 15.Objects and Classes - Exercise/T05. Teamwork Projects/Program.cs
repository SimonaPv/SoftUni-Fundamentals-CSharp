using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");

                Team currTeam = new Team();
                string creator = newTeam[0];
                string teamName = newTeam[1];

                if (teams.Any(currTeam => currTeam.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }

                else if (teams.Any(currName => currName.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team();
                    team.TeamName = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string line = Console.ReadLine();

            while (line != "end of assignment")
            {
                string[] teamChanges = line.Split("->");
                string memberName = teamChanges[0];
                string teamToJoin = teamChanges[1];

                if (teams.All(team => team.TeamName != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                else if (teams.Any(team => team.Members.Contains(memberName) || teams.Any(creator => creator.Creator == memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }

                else
                {
                    Team currTeam = teams.Find(team => team.TeamName == teamToJoin);
                    currTeam.Members.Add(memberName);
                }

                line = Console.ReadLine();
            }

            List<Team> completed = teams.Where(x => x.Members.Count > 0).ToList();
            List<Team> disband = teams.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in completed.OrderByDescending(x => x.Members.Count).ThenBy(y=>y.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var dissband in disband.OrderBy(x => x.TeamName))
            {
                Console.WriteLine($"{dissband.TeamName}");
            }
        }

    }
    class Team
    { 
        public string Creator { get; set; }
        public string TeamName { get; set; }    
        public List<string> Members { get; set; }
    }
}
