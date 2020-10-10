using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Rook : ChessPiece
    {
        public Rook(PieceColor pieceColor) : base(PieceName.Rook, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            throw new NotImplementedException();
        }
    }
}
