using Chess.ChessPieces;
using System;
using System.Collections.Generic;

namespace Chess
{
    class NormalChessBoard : ChessBoard.AbstractChessBoard
    {
        public NormalChessBoard(int rowSize, int colSize) : base(rowSize, colSize)
        {
            this.Set();
        }

        public override void Reset()
        {
            layout = new List<List<ChessPiece>>(rowSize);
            for (int i = 0; i < rowSize; i++)
            {
                layout[i] = new List<ChessPiece>(colSize);
                for (int j = 0; j < colSize; j++)
                {
                    layout[i][j] = new EmptyChessPiece();
                }
            }
        }

        public override void Set()
        {
            setPieceAt(new Rook(PieceColor.White), new Location('A', 1));
            setPieceAt(new Knight(PieceColor.White), new Location('B', 1));
            setPieceAt(new Bishop(PieceColor.White), new Location('C', 1));
            setPieceAt(new Queen(PieceColor.White), new Location('D', 1));
            setPieceAt(new King(PieceColor.White), new Location('E', 1));
            setPieceAt(new Bishop(PieceColor.White), new Location('F', 1));
            setPieceAt(new Knight(PieceColor.White), new Location('G', 1));
            setPieceAt(new Rook(PieceColor.White), new Location('H', 1));

            setPieceAt(new Pawn(PieceColor.White), new Location('A', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('B', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('C', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('D', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('E', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('F', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('G', 2));
            setPieceAt(new Pawn(PieceColor.White), new Location('H', 2));


            setPieceAt(new Rook(PieceColor.Black), new Location('A', 8));
            setPieceAt(new Knight(PieceColor.Black), new Location('B', 8));
            setPieceAt(new Bishop(PieceColor.Black), new Location('C', 8));
            setPieceAt(new Queen(PieceColor.Black), new Location('D', 8));
            setPieceAt(new King(PieceColor.Black), new Location('E', 8));
            setPieceAt(new Bishop(PieceColor.Black), new Location('F', 8));
            setPieceAt(new Knight(PieceColor.Black), new Location('G', 8));
            setPieceAt(new Rook(PieceColor.Black), new Location('H', 8));


            setPieceAt(new Pawn(PieceColor.Black), new Location('A', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('B', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('C', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('D', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('E', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('F', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('G', 7));
            setPieceAt(new Pawn(PieceColor.Black), new Location('H', 7));

        }

        public ChessPiece getPieceAt(Location location) 
        {
            return this.layout[location.rowNum][location.getColNum()];
        }

        public bool setPieceAt(ChessPiece chessPiece, Location location)
        {
            try
            {
                this.layout[location.rowNum - 1][location.getColNum()] = chessPiece;
                return true;
            }
            catch(Exception e) 
            {
                return false;
            }
        }
    }
}
