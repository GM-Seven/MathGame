using MathGame.Models;
using System;
using System.Security.AccessControl;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date= DateTime.Now.AddDays(-1) , Type = GameType.Addition, Score = 5},
            //new Game { Date= DateTime.Now.AddDays(-2), Type = GameType.Multiplication, Score = 4},
            //new Game { Date= DateTime.Now.AddDays(-3), Type = GameType.Division, Score = 4},
            //new Game { Date= DateTime.Now.AddDays(-4), Type = GameType.Subtraction, Score = 3},
            //new Game { Date= DateTime.Now.AddDays(-5), Type = GameType.Addition, Score = 1},
            //new Game { Date= DateTime.Now.AddDays(-6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date= DateTime.Now.AddDays(-7), Type = GameType.Division, Score = 3 },
            //new Game { Date= DateTime.Now.AddDays(-8), Type = GameType.Subtraction, Score = 4},
            //new Game { Date= DateTime.Now.AddDays(-9), Type = GameType.Addition, Score = 4},
            //new Game { Date= DateTime.Now.AddDays(-10), Type = GameType.Multiplication, Score = 1},
            //new Game { Date= DateTime.Now.AddDays(-11), Type = GameType.Subtraction, Score = 0},
            //new Game { Date= DateTime.Now.AddDays(-12), Type = GameType.Division, Score = 2},
            //new Game { Date= DateTime.Now.AddDays(-13), Type = GameType.Subtraction, Score = 5},
        };
        internal static void GameEnd(int gameScore, GameType gameType)
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

            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty.");
                name = Console.ReadLine();
            }

            return name;
        }
        internal static void PrintGames()
        {
            var gamesToPrint = games.OrderByDescending(x=> x.Date);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------------");

            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any button to return to the menu.");
            Console.ReadLine();
        }
        internal static string ValidateAnswer()
        {
            var answer = Console.ReadLine();
            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}
