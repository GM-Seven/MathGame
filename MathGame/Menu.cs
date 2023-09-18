namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void ShowMenu(string? name)
        {
            Console.WriteLine($"Hello {name}! Today is {DateTime.UtcNow.DayOfWeek}.");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"Select one of the following games:
v - View Game History
a - Addition
s - Subtraction
m - Multiplication
d - Division
q - quit");


                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame();
                        break;
                    case "s":
                        engine.SubtractionGame();
                        break;
                    case "m":
                        engine.MultiplicationGame();
                        break;
                    case "d":
                        engine.DivisionGame();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (isGameOn);

        }
    }
}
