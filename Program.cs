using System;
using System.Linq;
using System.Collections.Generic;
using Classes;

Main();

void Main()
{
    Team myTeam = new Team("The Fuckin Jokesters", new DateTime(1988, 08, 27));
    TeamMember Colin = new TeamMember("Colin", 55, 0.2);
    myTeam.TeamMembers.Add(Colin);
    Console.WriteLine("Plan Your Heist!");
    Console.WriteLine("================");
    Console.WriteLine("Enter your first team member's name - this is probably the main character I'd guess:  ");
    string memberName = Console.ReadLine();
    TeamMember firstMember = new TeamMember(memberName, 0, 0.0);
    myTeam.TeamMembers.Add(firstMember);
    Console.WriteLine($"{firstMember.Name}, got it. A real stand up person, I'm sure. Welcome to {myTeam.Name}");
    Console.WriteLine($"{myTeam.TeamMembers[0].Name} is also here. Say hi to him. He's not good at this but he's on the team. It's kind of this charity thing we do here.");
    Console.WriteLine($"OK, so this {firstMember.Name}.... what would you rate their overall skill? Any positive whole number will work.:  ");
    int memberSkill = Int32.Parse(Console.ReadLine());
    myTeam.TeamMembers[1].Skill = memberSkill;
    Console.WriteLine($"OK so that's a {memberSkill} for {firstMember.Name}'s skill. Noted. Seems low. But noted.");
    Console.WriteLine($"Another quick one about this {firstMember.Name} friend of yours.... what would you rate their overall courage on a scale of 0.0 to 2.0? What? This is a normal question, people ask it all the time:  ");
    double memberCourage = Convert.ToDouble(Console.ReadLine());
    myTeam.TeamMembers[1].Courage = memberCourage;
    Console.WriteLine($"Great, so that's a {memberCourage} for {firstMember.Name}'s courage. Man, that's kinda sad actually, poor kid. Anyway!");
    Console.WriteLine(@$"So here's what we've got:
        ****NAME*****: {myTeam.TeamMembers[1].Name}
        ****SKILL LEVEL*****: {myTeam.TeamMembers[1].Skill}
        ****COURAGE LEVEL*****: {myTeam.TeamMembers[1].Courage}
        ****OVERALL OUTLOOK*****: MEH KINDA HARD TO SAY TBH I WOULDN'T BET ON IT THO
    ");

}