using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class King : ChessPiece
    {
        public King(PieceColor pieceColor) : base(PieceName.King, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            throw new NotImplementedException();
        }
    }
}
