using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    class Bishop : ChessPiece
    {
        public Bishop(PieceColor pieceColor) : base(PieceName.Bishop, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            throw new NotImplementedException();
        }
    }
}
