using Chess.Display;
using System;

namespace Chess.Players
{
    public class Player
    {
        public Account account;

        public string gameName;

        public GameColor gameColor;

        public void getBasicInfo(GameColor? gameColor = null) 
        {
            this.getGameName();
            if (gameColor == null)
            {
                this.getGameColor();
            }
            else
            {
                this.setGameColor(gameColor);
            }
        }

        private void getGameName() 
        {
            DisplayUtilities.GetPlayerName();
            this.gameName = Console.ReadLine();
        }

        private void getGameColor()
        {
            DisplayUtilities.GetPlayerColor();
            Enum.TryParse<GameColor>(Console.ReadLine(), out this.gameColor);
        }

        private void setGameColor(GameColor? gameColor) 
        {
            this.gameColor = (GameColor)gameColor;
        }
    }

    public enum GameColor 
    {
        Black,
        White
    }
}
