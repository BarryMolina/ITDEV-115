using System;
using static System.Console;
namespace Molina_ElectionResultsApp
{
    public class ElectionUI
    {
        Election theElection;

        public ElectionUI()
        {
             theElection = new Election();
        }

        public void DisplayResults()
        {
            WriteLine("\t{0,-20}{1,-20}{2}", "Name", "Votes", "Percentage");
            WriteLine("____________________________________________________" +
                "_______\n");
            for (int x = 0; x < theElection.numCandidates; x++)
            {
                WriteLine("\t{0,-20}{1,-20}{2:F1}%", theElection.GetCandidateName(x),
                                                 theElection.GetCandidateVotes(x),
                                                 ((double)theElection.GetCandidateVotes(x) /
                                                 theElection.TotalVotes()) * 100);
            }
            WriteLine("\nThe winner is " + theElection.GetCandidateName(theElection.FindWinner()));
        }

        public void MainMethod()
        {
            string candidateName;
            int candidateVotes;

            for (int i = 0; i < theElection.numCandidates; i++)
            {
                candidateName = PromptforString(i);
                candidateVotes = PromptforInt(candidateName);

                theElection.SetCandidateName(candidateName, i);
                theElection.SetVotes(candidateVotes, i);
            }

            Clear();

            DisplayResults();

            ReadKey();
        }

        public int PromptforInt(string name)
        {
            int numVotes;

            Write("please enter {0}'s vote count: ", name);
            while (int.TryParse(ReadLine(), out numVotes) == false)
            {
                WriteLine("Error in input. Please enter an integer.");
                Write("please enter {0}'s vote count: ", name);
            }

            return numVotes;
        }

        public string PromptforString(int candidate)
        {
            Write("\nplease enter candidate {0}'s name: ", candidate + 1);
            return ReadLine();
        }
    }
}
