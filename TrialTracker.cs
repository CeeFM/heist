using System;

namespace Classes
{
    public class TrialTracker
    {

        // Some readonly properties (let's talk about gets, baby)
        public string TeamName { get; }
        public DateTime GameDate { get; }

        // Create a public property for holding a list of current employees
        public List<Trials> GameTrials { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public TrialTracker(string teamname, DateTime gamedate) {
            TeamName = teamname;
            GameDate = gamedate;
            GameTrials = new List<Trials>();
        }

        public void ListTrials(Trials trial)
        {
           Console.WriteLine($@"
           
           Your Team's Skill Was {trial.TeamScore} 
           
           And You Attempted to Rob A Bank With a ${trial.BankDifficulty}. 
           
           Success? {trial.BagSecured}
           
           ");
        }
    }
}