using HangedManClasses;

namespace HangedMan;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman \n" +
                          "______________________________");

        RandomWords rndmWrd = new RandomWords();
        string randomWord = rndmWrd.Generate();
        //Console.WriteLine(randomWord);

        List<string> truechrlst = new List<string>();

        List<string> falsechrlst = new List<string>();

        int level = 1;
        int attempts = 6;
        bool isRight = false;
        string? guess = "a";

        Draw objDraw = new Draw();
        for (int i = 0; i <= attempts; i++)
        {
            Console.Write("correct guess:");
            List<string> noDupestrue = truechrlst.Distinct().ToList();
            foreach (var ch in noDupestrue)
            {
                Console.Write(ch + ", ");
            }
            Console.WriteLine();

            Console.Write("wrong guess:");
            List<string> noDupesflse = falsechrlst.Distinct().ToList();
            foreach (var lt in noDupesflse)
            {
                Console.Write(lt + ", ");
            }
            Console.WriteLine();

            if (i < 3)
            {
                Console.WriteLine("Guess a letter:");
                guess = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Guess a letter or whole word:");
                guess = Console.ReadLine();
                if (guess.Length > 2 && guess == randomWord)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("You guessed it right XD");
                    Console.ResetColor();
                    break;
                }
                else if (guess.Length > 2 && guess != randomWord)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"GAME OVER!!! You guessed wrong! correct word: {randomWord}");
                    objDraw.DrawLevel(7);
                    Console.ResetColor();
                    break;
                }
            }

            for (int j = 0; j < randomWord.Length; j++)
            {
                if (guess[0] == randomWord[j])
                {
                    isRight = true;
                    truechrlst.Add(guess);
                    Console.WriteLine($"right. possible index => {j} \n");
                    break;
                }
                else
                {
                    isRight = false;

                }
            }
            if (isRight == false)
            {
                Console.WriteLine("wrong!!!\n");
                falsechrlst.Add(guess);
                objDraw.DrawLevel(level);

            }

            level++;
            if (i == attempts - 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"Hint: it's one of the programming languages or frameworks ¯\_(ツ)_/¯");
                Console.ResetColor();
            }
            if (i == attempts - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is the last chance");
                Console.ResetColor();
            }
            if (i == attempts)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You missed the last chance :(");
                objDraw.DrawLevel(7);
                Console.ResetColor();
            }
        }

    }

}