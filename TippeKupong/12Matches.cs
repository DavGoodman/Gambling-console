using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippeKupong
{
    internal class _12Matches
    {
        private string[] bets = new string[12];
        private Match[] matches = new Match[12];
        public int winCount = 0;
        public int loseCount = 0;

        // constructor
        public _12Matches(string[] _bets)
        {
            this.bets = _bets;
            setMatches();
            setBets();
        }


        private void setMatches()
        {
            for (int i = 0; i < 12; i++)
            {
                matches[i] = new Match();
            }
        }
        private void setBets()
        {
            for (int i = 0; i < 12; i++)
            {
                matches[i].bet = bets[i];
            }
        }

        public void runMatches()
        {
            for (int i = 0; i < 12; i++)
            {
                matches[i].runMatch();
                if (matches[i].isBetCorrect) winCount++;
                else loseCount++;
                Console.WriteLine($"Bets won: {winCount} \r\nBets lost: {loseCount}\r\n");
            }
        }

    }
}
