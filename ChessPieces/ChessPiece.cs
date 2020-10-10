using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public abstract class ChessPiece
    {
        public PieceName pieceName;

        public PieceColor pieceColor;

        public ChessPiece(PieceName pieceName, PieceColor pieceColor)
        {
            this.pieceColor = pieceColor;
            this.pieceName = pieceName;
        }

        public abstract bool IsValidMove();

        public override string ToString()
        {
            string pieceKey = $"{pieceColor}_{pieceName}";

            // padding with space
            while (pieceKey.Length < 15)
            {
                pieceKey = pieceKey + " ";
            }

            return pieceKey;
        }
    }

    public enum PieceName 
    {
        Rook,
        Bishop,
        Pawn,
        King,
        Queen,
        Horse,
        Empty
    }

    public enum PieceColor
    {
        White,
        Black,
        Empty
    }
}
