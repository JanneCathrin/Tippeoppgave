using System;

namespace parprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
            var match = new Match(bet);
            while (match.IsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                var command = Console.ReadLine();
                if (command == "X") match.Stop();
                else if (command == "H" || command == "B") match.AddGoal(command == "H");
                Console.WriteLine($"Stillingen er {match.GetScore()}.");
            }


            var IsBetCorrectText = match.IsBetCorrect() ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {IsBetCorrectText}");
        }
    }
}
