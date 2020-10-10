using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Rook : ChessPiece
    {
        public Rook(PieceColor pieceColor) : base(PieceName.Rook, pieceColor) { }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool IsValidMove()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
