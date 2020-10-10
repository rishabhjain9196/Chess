using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class EmptyChessPiece : ChessPiece
    {
        public EmptyChessPiece() : base(PieceName.Empty, PieceColor.Empty) { }

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
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
