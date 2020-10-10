﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class EmptyChessPiece : ChessPiece
    {
        public EmptyChessPiece() : base(PieceName.Empty, PieceColor.Empty) { }

        public override bool IsValidMove(Location from, Location to)
        {
            return false;
        }
    }
}
