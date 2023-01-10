using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippeKupong
{
    public class Match
    {
        private int homeGoals = 0;
        private int awayGoals = 0;
        private bool matchIsRunning = false;

        public string bet { get; set; }
        private string result { get; set; }
        public bool isBetCorrect { get; set; }
        private string isBetCorrectText { get; set; }

        public void runMatch()
        {
            matchIsRunning = true;
            while (matchIsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                matchIsRunning = command != "X";
                addGoal(command);
                Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            }
            resolveMatch();
        }

        private void resolveMatch()
        {
            getScore();
            Console.WriteLine($"Du tippet {isBetCorrectText}");
            matchIsRunning = false;
        }

        private void addGoal(string command)
        {
            if (command == "H") homeGoals++;
            else if (command == "B") awayGoals++;
        }

        private void getScore()
        {
            result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            isBetCorrect = bet.Contains(result);
            isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            
        }

        private void Stop()
        {

        }
    }
}
