using Chess.ChessPieces;
using System.Collections.Generic;

namespace Chess
{
    class NormalChessBoard : ChessBoard.AbstractChessBoard
    {
        public NormalChessBoard(int rowSize, int colSize) : base(rowSize, colSize)
        {
        }

        public override void Reset()
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

        public override void Set()
        {
            
        }
    }
}
