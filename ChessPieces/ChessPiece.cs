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
