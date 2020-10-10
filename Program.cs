using Chess.Display;
using Chess.Players;
using System;
using System.Collections.Generic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayUtilities.Intro();

            Player player1 = new Player();
            player1.getBasicInfo();

            bool isFirst = player1.gameColor == GameColor.White;
            Player player2 = new Player();
            player2.getBasicInfo(isFirst ? GameColor.Black : GameColor.White);

            List<Player> players = new List<Player>();

            if (player1.gameColor == GameColor.White)
            {
                players.Add(player1);
                players.Add(player2);
            }
            else 
            {
                players.Add(player2);
                players.Add(player1);
            }

            ChessGame game = new ChessGame(players);
            game.Start();
        }
    }
}
