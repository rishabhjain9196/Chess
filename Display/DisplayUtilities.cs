using Chess.ChessBoard;
using Chess.Players;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chess.Display
{
    public static class DisplayUtilities
    {
        public static void DashLine(int length = 100) 
        {
            for(int i=0; i<length; i++)
                Console.Write("-");
            Console.WriteLine();
        }

        public static void Line() 
        {
            Console.WriteLine();
        }

        public static void Intro() 
        {
            DashLine();
            Line();
            Console.WriteLine("Welcome to Console Chess Application");
            Console.WriteLine("Developed By: Rishabh Jain");
            Line();
            DashLine();
        }

        public static void PrintChessBoard(AbstractChessBoard chessBoard) 
        {
            Line();
            DashLine();
            chessBoard.PrintBoard();
            DashLine();
            Line();
        }

        public static void PromptPlayerMove(Player player) 
        {
            Line();
            Console.WriteLine($"{player.gameName} turn to play - provide initial and final positions to move");
            Line();
        }
    }
}
