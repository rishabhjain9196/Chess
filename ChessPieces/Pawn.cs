using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Pawn : ChessPiece
    {
        public Pawn(PieceColor pieceColor) : base(PieceName.Pawn, pieceColor) { }

        public override bool IsValidMove(Location from, Location to)
        {
            bool isValid = from.colKey == to.colKey && to.rowNum - from.rowNum == 1; 
            return isValid;
        }
    }
}
