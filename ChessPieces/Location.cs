using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ChessPieces
{
    public class Location
    {
        public int rowNum;

        public char colKey;

        public Location(char col, int row) 
        {
            this.rowNum = row;
            this.colKey = col;
        }

        public Location(string location) 
        {
            if (location.Length != 2) 
            {
                throw new Exception("Invalid Location");
            }

            this.colKey = location[0];
            this.rowNum = location[1] - '0';
        }

        public int getColNum()
        {
            if (colKey >= 'A' && colKey <= 'Z')
            {
                return colKey - 'A';
            }
            else if (colKey >= 'a' && colKey <= 'z')
            {
                return colKey - 'a';
            }
            else 
            {
                throw new Exception("Invalid Column Key Value");
            }
        }
    }
}
