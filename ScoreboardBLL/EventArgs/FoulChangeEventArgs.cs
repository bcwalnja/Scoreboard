namespace ScoreboardBLL
{
    public class FoulChangeEventArgs : System.EventArgs
    {
        public GameFouls GameFouls { get; }

        public FoulChangeEventArgs(GameFouls gameFouls)
        {
            this.GameFouls = gameFouls;
        }
    }
}