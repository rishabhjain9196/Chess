using Chess.ChessBoard;
using Chess.ChessPieces;
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

                string command = Console.ReadLine();
                if (command == "q") 
                {
                    gameState = GameState.Ended;
                    break;
                }
                var locations = command.Split(new char[] { ' ' });
                var  moveResult = this.Move(currentPlayer, new Location(locations[0]), new Location(locations[2]));
                if (moveResult != MoveResult.Invalid)
                {
                    UpdateCurrentPlayer();
                }
                else
                {
                    Console.WriteLine($"Invalid Move by {currentPlayer.gameName}. Please retry.");
                }
            }

            Console.ReadKey();
        }


        public MoveResult Move(Player player, Location from, Location to)
        {
            try
            {
                var from_piece = this.chessBoard.getPieceAt(from);
                var to_piece = this.chessBoard.getPieceAt(to);

                // Validation - Player should move only his piece
                if (player.gameColor.ToString() != from_piece.pieceColor.ToString()) 
                {
                    Console.WriteLine("Validation - Player should move only his piece failed");
                    return MoveResult.Invalid;
                }

                // Validation - player can't kill self piece
                if (from_piece.pieceColor == to_piece.pieceColor)
                {
                    Console.WriteLine("Validation - player can't kill self piece failed");
                    return MoveResult.Invalid;
                }

                // Validation - From can't be Empty
                if (from_piece.pieceName == new EmptyChessPiece().pieceName)
                {
                    Console.WriteLine("Validation - From can't be Empty failed");
                    return MoveResult.Invalid;
                }

                try
                {
                    // Validation - Is Move Possible
                    if (!from_piece.IsValidMove(from, to))
                    {
                        Console.WriteLine("Validation - Is Move Possible failed");
                        return MoveResult.Invalid;
                    }
                }
                catch (Exception) 
                {
                    return MoveResult.Valid;
                }

                // Kill Log
                if (to_piece.pieceName != PieceName.Empty && to_piece.pieceColor.ToString() != currentPlayer.gameColor.ToString()) 
                {
                    Console.WriteLine($"{currentPlayer.gameName} killed {to_piece} with {from_piece}.");
                    return to_piece.pieceColor == PieceColor.Black ? MoveResult.BlackKill : MoveResult.WhiteKill;
                }

                this.chessBoard.setPieceAt(from_piece, to);
                this.chessBoard.setPieceAt(new EmptyChessPiece(), from);
                return MoveResult.Valid;
            }
            catch (Exception) 
            {
                return MoveResult.Invalid;
            }
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

    public enum MoveResult 
    {
        Invalid,
        WhiteKill,
        BlackKill,
        WhiteKingKilled,
        BlackKingKilled,
        Valid
    }
}
