// See https://aka.ms/new-console-template for more information
using static TicTacToe.GameBoard;

Console.WriteLine("Hello, World!");

//static void Main(string[] args)
{
    var game = new TicTacToen();
    while (true)
    {
        Console.WriteLine(game);
        Console.WriteLine($"Player {game._currentPlayer}, enter your move (row col): ");
        var input = Console.ReadLine();
        var parts = input.Split(' ');
        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid input. Please try again.");
            continue;
        }

        if (!int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col))
        {
            Console.WriteLine("Invalid input. Please try again.");
            continue;
        }

        if (!game.MakeMove(row, col))
        {
            Console.WriteLine("Invalid move. Please try again.");
            continue;
        }

        var winner = game.CheckWinner();
        if (winner != ' ')
        {
            Console.WriteLine($"Player {winner} wins!");
            Console.ReadLine();
            break;
        }
    }
}
