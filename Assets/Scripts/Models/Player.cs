namespace BallJumper.Models
{
    public class Player
    {
        public int Score { get; private set; }

        public Player() => Score = Constants.DefaultScore;
        
        public Player(int score) => Score = score;
        
        public void IncrementScore() =>
            Score++;
    }
}
