using Chess.Players;
using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Chess Application!");

            Player player1 = new Player();
            Console.WriteLine("Enter Player 1 Name");
            player1.gameName = Console.ReadLine();

            Player player2 = new Player();
            Console.WriteLine("Enter Player 2 Name");
            player2.gameName = Console.ReadLine();

            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);

            ChessGame game = new ChessGame(players);
            game.Start();
        }
    }
}
