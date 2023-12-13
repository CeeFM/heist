using System;

namespace Classes
{
    public class Trials
    {

        // Some readonly properties (let's talk about gets, baby)
        public int TeamScore { get; set; }
        public int BankDifficulty { get; set; }
        public bool BagSecured { get; set; }

        // Create a public property for holding a list of current employees
        public Trials(int teamscore, int bankdifficulty, bool bagsecured) {
            TeamScore = teamscore;
            BankDifficulty = bankdifficulty;
            BagSecured = bagsecured;
        }

    }
}