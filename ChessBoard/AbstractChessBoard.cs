using Chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Chess.ChessBoard
{
    public abstract class AbstractChessBoard
    {
        public int rowSize;
        public int colSize;

        public List<List<ChessPiece>> layout;

        public AbstractChessBoard(int rowSize, int colSize) 
        {
            layout = new List<List<ChessPiece>>(rowSize);
            for (int i = 0; i < rowSize; i++) 
            {
                for (int j = 0; j < colSize; j++)
                {
                    layout[i].Add(new EmptyChessPiece());
                }
            }
        }

        public abstract void Reset();

        public abstract void Set();

        public virtual void PrintBoard() 
        {
            for (int i=0; i<rowSize; i++) 
            {
                for (int j=0; j<colSize; j++) 
                {
                    Console.Write(layout[i][j].pieceColor + ":" + layout[i][j].pieceName);
                }
            }
        }

    }
}
