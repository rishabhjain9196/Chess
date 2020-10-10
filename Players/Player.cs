namespace Chess.Players
{
    public class Player
    {
        public Account account;

        public string gameName;

        public GameColor gameColor;
    }

    public enum GameColor 
    {
        Black,
        White
    }
}
