using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Knight : ChessPiece
    {
        public Knight(PieceColor pieceColor) : base(PieceName.Knight, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            throw new NotImplementedException();
        }
    }
}
