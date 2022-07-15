namespace TicTacToe;

public class ClassGameBoard
{
    public static char[] boardChars = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {boardChars[1]}  |  {boardChars[2]}  |  {boardChars[3]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {boardChars[4]}  |  {boardChars[5]}  |  {boardChars[6]}");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {boardChars[7]}  |  {boardChars[8]}  |  {boardChars[9]}");
        Console.WriteLine("     |     |      ");
    }
}

class Check
{
    public static int CheckWin()
    {
        if (ClassGameBoard.boardChars[1] == ClassGameBoard.boardChars[2] && ClassGameBoard.boardChars[2] == ClassGameBoard.boardChars[3])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[4] == ClassGameBoard.boardChars[5] && ClassGameBoard.boardChars[5] == ClassGameBoard.boardChars[6])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[6] == ClassGameBoard.boardChars[7] && ClassGameBoard.boardChars[7] == ClassGameBoard.boardChars[8])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[1] == ClassGameBoard.boardChars[4] && ClassGameBoard.boardChars[4] == ClassGameBoard.boardChars[7])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[2] == ClassGameBoard.boardChars[5] && ClassGameBoard.boardChars[5] == ClassGameBoard.boardChars[8])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[3] == ClassGameBoard.boardChars[6] && ClassGameBoard.boardChars[6] == ClassGameBoard.boardChars[9])
        {
            return 1;
        }

        else if (ClassGameBoard.boardChars[1] == ClassGameBoard.boardChars[5] && ClassGameBoard.boardChars[5] == ClassGameBoard.boardChars[9])
        {
            return 1;
        }
        else if (ClassGameBoard.boardChars[3] == ClassGameBoard.boardChars[5] && ClassGameBoard.boardChars[5] == ClassGameBoard.boardChars[7])
        {
            return 1;
        }


        else if (ClassGameBoard.boardChars[1] != '1' && ClassGameBoard.boardChars[2] != '2' && ClassGameBoard.boardChars[3] != '3' && ClassGameBoard.boardChars[4] != '4' && ClassGameBoard.boardChars[5] != '5' && ClassGameBoard.boardChars[6] != '6' && ClassGameBoard.boardChars[7] != '7' && ClassGameBoard.boardChars[8] != '8' && ClassGameBoard.boardChars[9] != '9')
        {
            return -1;
        }

        else
        {
            return 0;
        }
    }
}