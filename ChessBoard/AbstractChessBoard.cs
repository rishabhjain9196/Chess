using Chess.ChessPieces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Chess.ChessBoard
{
    public abstract class AbstractChessBoard
    {
        public int rowSize;
        public int colSize;

        public List<List<ChessPiece>> layout;

        public AbstractChessBoard(int rowSize, int colSize) 
        {
            this.rowSize = rowSize;
            this.colSize = colSize;

            // initialize board
            layout = new List<List<ChessPiece>>();
            for (int i = 0; i < rowSize; i++) 
            {
                layout.Add(new List<ChessPiece>());
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
            char rowKey = 'A';
            char colKey = '1';
            char blankKey = ' ';

            Console.Write(getPaddedKey(blankKey, 15) + " ");

            for (int i = 0; i < colSize; i++) 
            {
                Console.Write(getPaddedKey(rowKey, 15) + " ");
                rowKey++;
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i=0; i<rowSize; i++) 
            {
                Console.Write(getPaddedKey(colKey,15) + " ");
                
                for (int j=0; j<colSize; j++) 
                {
                    Console.Write(layout[i][j].ToString() +  " ");
                }

                Console.Write(getPaddedKey(colKey, 15) + " ");

                Console.WriteLine();
                colKey++;
            }

            Console.WriteLine();

            Console.Write(getPaddedKey(blankKey, 15) + " ");
            rowKey = 'A';
            for (int i = 0; i < colSize; i++)
            {
                Console.Write(getPaddedKey(rowKey, 15) + " ");
                rowKey++;
            }

            Console.WriteLine();
        }

        private string getPaddedKey(char key, int pad) 
        {
            string paddedKey = string.Empty + key;
            for (int i = 0; i < pad - 1; i++) 
            {
                paddedKey = paddedKey + " ";
            }

            return paddedKey;
        }

        public virtual ChessPiece getPieceAt(Location location)
        {
            return this.layout[location.rowNum - 1][location.getColNum()];
        }

        public virtual bool setPieceAt(ChessPiece chessPiece, Location location)
        {
            try
            {
                this.layout[location.rowNum - 1][location.getColNum()] = chessPiece;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
