namespace TicTacToe;

class Program : object
{
    public Program() : base()
    {
    }

    public static void Main()
    {
        Console.WriteLine("Welcome to Tic Tac Teo Game:");
        char playerOneChar;
        char playerTwoChar;
        Console.WriteLine("choose X or O");
        while (true)
        {
            var k = Console.ReadLine().ToUpper();
            if (k != "")
            {
                playerOneChar = Convert.ToChar(k);
                if (playerOneChar == 'X')
                {
                    playerTwoChar = 'O';
                    break;
                }
                else if (playerOneChar == 'O')
                {
                    playerTwoChar = 'X';
                    break;
                }
                else
                {
                    Console.WriteLine("just X and O accept! Re-enter:");
                    //k = Console.ReadLine().ToUpper();
                    continue;
                }
            }
            else if (k == "")
            {
                Console.WriteLine("can't be null!");
                Console.WriteLine("choose X or O");
                continue;
            }
        }

        Console.WriteLine("-------------------------------------");

        var objBoard = new ClassGameBoard();
        int player = 1;
        int choice;
        int flag = 0;

        do
        {
            Console.Clear();// whenever loop will be again start then screen will be clear
            Console.WriteLine($"Player one play as: {playerOneChar}");
            Console.WriteLine($"player Two play as: {playerTwoChar}");
            Console.WriteLine("\n");
            if (player % 2 == 0)//checking the chance of the player
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
            objBoard.Board();
            Console.WriteLine("Choose between rows");
            choice = int.Parse(Console.ReadLine());

            if (ClassGameBoard.boardChars[choice] != 'X' && ClassGameBoard.boardChars[choice] != 'O')
            {
                if (player % 2 == 0)
                {
                    ClassGameBoard.boardChars[choice] = playerTwoChar;
                    player++;
                }
                else
                {
                    ClassGameBoard.boardChars[choice] = playerOneChar;
                    player++;
                }
            }
            else
            {
                Console.WriteLine($"Sorry the row {choice} is already marked with {ClassGameBoard.boardChars[choice]}");
                Thread.Sleep(2000);
            }
            flag = Check.CheckWin();
        }
        while (flag != 1 && flag != -1);
        Console.Clear();
        objBoard.Board();
        if (flag == 1)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Player {(player % 2) + 1} has won");
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Draw");
            Console.ResetColor();
        }
    }
}