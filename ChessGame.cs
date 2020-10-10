using Chess.ChessBoard;
using Chess.Display;
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
            chessBoard = new NormalChessBoard(8,8);
            this.gameState = GameState.NotStarted;
        }

        public void Start() 
        {
            DisplayUtilities.Intro();

            this.gameState = GameState.Active;
            while (this.gameState == GameState.Active) 
            {
                DisplayUtilities.PrintChessBoard(chessBoard);
                DisplayUtilities.PromptPlayerMove(currentPlayer);


                UpdateCurrentPlayer();
                gameState = GameState.Ended;
            }

            Console.ReadKey();
        }


        public void UpdateCurrentPlayer()
        {
            if (players[0] == this.currentPlayer)
            {
                this.currentPlayer = players[1];
            }
            else 
            {
                this.currentPlayer = players[0];
            }
        }

    }


    public enum GameState
    {
        NotStarted,
        Active,
        Ended
    }
}
