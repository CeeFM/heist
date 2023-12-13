using System;

namespace Classes
{
    public class Team
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<TeamMember> TeamMembers { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Team(string name, DateTime createdon) {
            Name = name;
            CreatedOn = createdon;
            TeamMembers = new List<TeamMember>();
        }

        public void ListTeamMembers(Team team, TeamMember teammember)
        {
           Console.WriteLine($"{teammember.Name} has {teammember.Skill} skill points and {teammember.Courage} courage points");
        }
    }
}