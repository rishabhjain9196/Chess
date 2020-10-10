using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Queen : ChessPiece
    {
        public Queen(PieceColor pieceColor) : base(PieceName.Queen, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            throw new NotImplementedException();
        }
    }
}
