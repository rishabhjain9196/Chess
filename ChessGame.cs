using Chess.ChessBoard;
using Chess.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class ChessGame
    {
        public TimeSpan GameTime;
        public TimeSpan ElapsedTime;
        public List<Player> players;

        public Player currentPlayer;
        public GameState gameState;
        public AbstractChessBoard chessBoard;


        public ChessGame(List<Player> players) 
        {
            if(players.Count < 2) 
            {
                throw new Exception("Player Count cannot be less than 2");
            }

            this.players = players;
            currentPlayer = players[0];
            chessBoard = new NormalChessBoard();
        }

        public void Start() 
        {
            Console.WriteLine("Welcome to Chess Online");

        }
    }

    public enum GameState
    {
        NotStarted,
        Active,
        Ended
    }
}
