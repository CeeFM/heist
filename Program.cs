using System;
using System.Linq;
using System.Collections.Generic;
using Classes;
using System.Security.Cryptography.X509Certificates;

Main();

void Main()
{
     int bankDifficulty = 100;
    Team myTeam = new Team("", System.DateTime.Now);
    TrialTracker scoreBook = new TrialTracker(myTeam.Name, System.DateTime.Now);
    Console.WriteLine("Plan Your Heist!");
    Console.WriteLine("================");
    Console.WriteLine();
    Console.WriteLine("Enter a number for the bank difficulty level (default is 100)");
    try
    {
    bankDifficulty = Convert.ToInt32(Console.ReadLine());
    }
    catch(Exception)
    {
    bankDifficulty = 100;
    }
    Console.WriteLine();
    Console.WriteLine("Enter A Name For Your Crazy Team of Criminals Or Whatever You Wanna Be Referred As:  ");
    Console.WriteLine();
    myTeam.Name = Console.ReadLine();
    int trials = 0;
    PickTeam();
    for (int i = 0; i < trials; i++)
    {
        bankDifficulty = bankDifficulty;
        Result();
    }
    int success = 0;
    int failure = 0;

    for (int i = 0; i < scoreBook.GameTrials.Count; i++)
    {
        if (scoreBook.GameTrials[i].BagSecured)
        {
            success += 1;
        }
        else
        {
            failure += 1;
        }
    }
    Console.WriteLine($@"You just ran:


    ***** {trials} TRIALS ***** 

             featuring
    
    ***** {success} successful runs ******

    **** {failure} failed runs ****** 
    


    Try again I guess if you enjoy this type of thing? Not really for me but seems like you're having fun?
    
    
    ");


void PickTeam()
{   bool ending = false;
    while (!ending) 
    {
    Console.WriteLine();
    Console.WriteLine("Enter a criminal's - oh sorry - your 'TEAM MATE's name (if you're done entering team members, just press ENTER):  ");
    Console.WriteLine();
    int i = myTeam.TeamMembers.Count;
    string memberName = Console.ReadLine();
    if (memberName == "")
    {
        Console.WriteLine();
        Console.WriteLine(@$"How many trial runs do you want to put your team through? I don't know what this means, I'm just following instructions:    ");
        try
        {
        trials = Convert.ToInt32(Console.ReadLine());
        }
        catch(Exception)
        {
        trials = 1;
        }
        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(@$"So here's what we've got...{myTeam.Name} has {myTeam.TeamMembers.Count} members. You want them to run {trials} trials. Good luck with that!!");
        Console.WriteLine();
        break;
    }
    TeamMember newMember = new TeamMember(memberName, 0, 0.0);
    myTeam.TeamMembers.Add(newMember);
    Console.WriteLine($"{newMember.Name}, got it. A real stand up person, I'm sure. Welcome to {myTeam.Name}, {newMember.Name}");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"OK, so this {newMember.Name}.... what would you rate their overall skill? Any positive whole number will work.:  ");
    int memberSkill = 0;
    try
    {
    memberSkill = Int32.Parse(Console.ReadLine());
    }
    catch(Exception)
    {
    memberSkill = 0;
    }
    myTeam.TeamMembers[i].Skill = memberSkill;
    Console.WriteLine();
    Console.WriteLine($"OK so that's a {memberSkill} for {newMember.Name}'s skill. Noted. Seems low. But noted.");
    Console.WriteLine();
    Console.WriteLine($"Another quick one about this {newMember.Name} friend of yours.... what would you rate their overall courage on a scale of 0.0 to 2.0? What? This is a normal question, people ask it all the time:  ");
    double memberCourage = 0.0;
    try
    {
    memberCourage = Convert.ToDouble(Console.ReadLine());
    }
    catch(Exception)
    {
    memberCourage = 0;
    }
    myTeam.TeamMembers[i].Courage = memberCourage;
    Console.WriteLine();
    Console.WriteLine($"Great, so that's a {memberCourage} for {newMember.Name}'s courage. Man, that's kinda sad actually, poor kid. Anyway!");
    Console.WriteLine();
//  UNAPOLOGETICALLY stashing a for loop here in case i want it and am too lazy to type it out
    // for (int k = 0; k < myTeam.TeamMembers.Count; k++ )
    // {
        
    // }
}

}
    void Result()
    {
    Random r = new Random();
    int genRand= r.Next(-10,10);
    int luckValue = genRand;
    int newbankDifficulty = bankDifficulty + luckValue;
    int TeamSkill = myTeam.TeamMembers.Sum(n => n.Skill);
    Console.WriteLine();
    Console.WriteLine($"Your Team's Combined Skill is {TeamSkill}. And you're attempting to rob a bank with a difficulty score of {newbankDifficulty}");

    if (TeamSkill < newbankDifficulty) {
        Trials result = new Trials(TeamSkill, newbankDifficulty, false);
        scoreBook.GameTrials.Add(result);
        Console.WriteLine();
        Console.WriteLine("YOU GOT BUSTED YOU NERDS TRY AGAINNN WITH BETTER PEOPLEEEEEEEEE");
        Console.WriteLine();
    }
    else
    {
        Trials result = new Trials(TeamSkill, newbankDifficulty, true);
        scoreBook.GameTrials.Add(result);
        Console.WriteLine();
        Console.WriteLine("ZOINKS THIS TEAM CAN REALLY DO IT DO IT THEY JUST ROBBED THE JOINT FOR A BAZZILLION GEORGIES OH MY GOD");
        Console.WriteLine();
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