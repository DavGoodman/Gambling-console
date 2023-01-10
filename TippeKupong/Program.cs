
namespace TippeKupong
{
    internal class Program
    {
        static void Main()
        {
            //oneMatch();

            // H,H,H,P,P,P,H,H,H,B,B,B
            twelveMatches();
        }

        static void oneMatch()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");


            Match match = new Match();

            match.bet = Console.ReadLine();
            match.runMatch();

        }

        static void twelveMatches()
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nSkriv inn dine 12 tips med komma mellom: ");

            var betsText = Console.ReadLine();
            var bets = betsText.Split(',');
            _12Matches twelveMatches = new _12Matches(_bets: bets);

            twelveMatches.runMatches();
        }
    }
}