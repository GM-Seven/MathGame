namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            Console.Clear();
            Console.WriteLine("Addition game selected");
            var random = new Random();
            int number1;
            int number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);
                Console.WriteLine($"{number1} + {number2}");
                var answer = Helpers.ValidateAnswer();
                var result = number1 + number2;

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("That is the correct answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("That is an incorrect answer!");
                }
                if (i == 4) break;
                Console.WriteLine("\n");
                Console.WriteLine("Press any key for the next question.");
                Console.ReadLine();
            }

            Helpers.GameEnd(score, Models.GameType.Addition);
        }
        internal void SubtractionGame()
        {
            Console.Clear();
            Console.WriteLine("Subtraction game selected");
            var random = new Random();
            int number1;
            int number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);
                Console.WriteLine($"{number1} - {number2}");
                var answer = Helpers.ValidateAnswer();
                var result = number1 - number2;

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("That is the correct answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("That is an incorrect answer!");
                }
                if (i == 4) break;
                Console.WriteLine("\n");
                Console.WriteLine("Press any key for the next question.");
                Console.ReadLine();
            }

            Helpers.GameEnd(score, Models.GameType.Subtraction);
        }
        internal void MultiplicationGame()
        {
            Console.Clear();
            Console.WriteLine("Multiplication game selected");
            var random = new Random();
            int number1;
            int number2;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                number1 = random.Next(1, 9);
                number2 = random.Next(1, 9);
                Console.WriteLine($"{number1} * {number2}");
                var answer = Helpers.ValidateAnswer();
                var result = number1 * number2;

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("That is the correct answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("That is an incorrect answer!");
                }
                if (i == 4) break;
                Console.WriteLine("\n");
                Console.WriteLine("Press any key for the next question.");
                Console.ReadLine();
            }

            Helpers.GameEnd(score, Models.GameType.Multiplication);
        }
        internal void DivisionGame()
        {
            Console.Clear();
            Console.WriteLine("Division game selected");
            var random = new Random();
            int number1;
            int number2;
            int result;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                number2 = random.Next(1, 10);
                result = random.Next(1, 10);
                number1 = number2 * result;
                Console.WriteLine($"{number1} / {number2}");
                var answer = Helpers.ValidateAnswer();

                if (int.Parse(answer) == result)
                {
                    Console.WriteLine("That is the correct answer!");
                    score++;
                }
                else
                {
                    Console.WriteLine("That is an incorrect answer!");
                }
                if (i == 4) break;
                Console.WriteLine("\n");
                Console.WriteLine("Press any key for the next question.");
                Console.ReadLine();
            }

            Helpers.GameEnd(score, Models.GameType.Division);
        }
    }
}
