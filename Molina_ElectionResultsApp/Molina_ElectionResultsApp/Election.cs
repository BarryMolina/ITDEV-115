using System;
namespace Molina_ElectionResultsApp
{
    public class Election
    {
        private const int NUMCANDIDATES = 5;
        string[] candidates = new string [NUMCANDIDATES];
        int[] votes = new int [NUMCANDIDATES];

        public int numCandidates
        {
            get 
            {
                return NUMCANDIDATES; 
            }
        }

        public Election()
        {
        }

        public int FindWinner()
        {
            int mostVotes = 0;

            for (int x = 1; x < votes.Length; x++)
            { 
                if (votes[x] > votes[mostVotes])
                { 
                    mostVotes = x;
                }
            }

            return mostVotes;
        }

        public string GetCandidateName(int index)
        {
            return candidates[index];
        }

        public int GetCandidateVotes(int index)
        { 
            return votes[index];
        }

        public void SetCandidateName(string value, int index)
        {
            candidates[index] = value;
        }

        public void SetVotes(int votes, int index)
        { 
            this.votes[index] = votes;
        }

        public int TotalVotes()
        {
            int sum = 0;

            for (int i = 0; i < votes.Length; i++)
            {
                sum += votes[i];
            }

            return sum;
        }
    }
}
