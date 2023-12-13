using System;
using System.Linq;
using System.Collections.Generic;
using Classes;

Main();

void Main()
{
    Team myTeam = new Team("The Fuckin Jokesters", new DateTime(1988, 08, 27));
    Console.WriteLine("Plan Your Heist!");
    Console.WriteLine("================");
    Console.WriteLine();
    PickTeam();

void PickTeam()
{   bool ending = false;
    while (!ending) 
    {
    Console.WriteLine("Enter this crimin...I mean your team member's name:  ");
    int i = myTeam.TeamMembers.Count;
    string memberName = Console.ReadLine();
    if (memberName == "")
    {
        ending = true;
        break;
    }
    TeamMember newMember = new TeamMember(memberName, 0, 0.0);
    myTeam.TeamMembers.Add(newMember);
    Console.WriteLine($"{newMember.Name}, got it. A real stand up person, I'm sure. Welcome to {myTeam.Name}, {newMember.Name}");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"OK, so this {newMember.Name}.... what would you rate their overall skill? Any positive whole number will work.:  ");
    int memberSkill = Int32.Parse(Console.ReadLine());
    myTeam.TeamMembers[i].Skill = memberSkill;
    Console.WriteLine();
    Console.WriteLine($"OK so that's a {memberSkill} for {newMember.Name}'s skill. Noted. Seems low. But noted.");
    Console.WriteLine();
    Console.WriteLine($"Another quick one about this {newMember.Name} friend of yours.... what would you rate their overall courage on a scale of 0.0 to 2.0? What? This is a normal question, people ask it all the time:  ");
    double memberCourage = Convert.ToDouble(Console.ReadLine());
    myTeam.TeamMembers[i].Courage = memberCourage;
    Console.WriteLine();
    Console.WriteLine($"Great, so that's a {memberCourage} for {newMember.Name}'s courage. Man, that's kinda sad actually, poor kid. Anyway!");
    Console.WriteLine();
    Console.WriteLine(@$"So here's what we've got...{myTeam.Name} has {myTeam.TeamMembers.Count} members, as follows:");
    Console.WriteLine();
    int bankDifficulty = 100;
    int TeamSkill = myTeam.TeamMembers.Sum(n => n.Skill);
    Console.WriteLine(TeamSkill);
    if (TeamSkill < bankDifficulty) {
        Console.WriteLine("YOU GOT BUSTED MOTHER FUCKERRRRRRR TRY AGAINNN WITH BETTER PEOPLEEEEEEEEE");
    }
    else
    {
        Console.WriteLine("YOINKS THIS TEAM CAN REALLY DO IT DO IT THEY JUST ROBBED THE JOINT FOR A BAZZILLION GEORGIES OH MY GOD");
    }
//  UNAPOLOGETICALLY stashing a for loop here in case i want it and am too lazy to type it out
    // for (int k = 0; k < myTeam.TeamMembers.Count; k++ )
    // {
        
    // }
}

}
}


// old loop for displaying each team member's info, felt like useful copypasta to stick on the wall

    // for (int k = 0; k < myTeam.TeamMembers.Count; k++ )
    // {
    //     Console.WriteLine(@$"

    //     ****NAME*****: {myTeam.TeamMembers[k].Name}

    //     ****SKILL LEVEL*****: {myTeam.TeamMembers[k].Skill}

    //     ****COURAGE LEVEL*****: {myTeam.TeamMembers[k].Courage}

    //     ****OVERALL OUTLOOK*****: MEH KINDA HARD TO SAY TBH I WOULDN'T BET ON IT THO
        
    //     ");
    // }