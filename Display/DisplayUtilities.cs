using Chess.ChessBoard;
using Chess.Players;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Chess.Display
{
    public static class DisplayUtilities
    {
        public static void DashLine(int length = 150) 
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
            Console.WriteLine($"{player.gameName} turn to play. E.g D5 to E1");
            Line();
        }

        public static void GetPlayerName() 
        {
            Line();
            Console.WriteLine("Enter Player Name..");
            Line();
        }

        public static void GetPlayerColor() 
        {
            Line();
            Console.WriteLine("Choose your colour");
            Console.WriteLine("0. Black");
            Console.WriteLine("1. White (First Turn)");
            Line();
        }
    }
}
