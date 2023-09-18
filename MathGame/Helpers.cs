using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();
        internal static void GameEnd(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });

            Console.WriteLine($"\nGame Over. Your score is {gameScore}");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadLine();
        }
        internal static string GetName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            return name;
        }
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any button to return to the menu.");
            Console.ReadLine();
        }
    }
}
