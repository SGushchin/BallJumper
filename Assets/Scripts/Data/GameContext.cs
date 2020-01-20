using BallJumper.Models;


namespace BallJumper.Data
{
    public sealed class GameContext
    {
        public Player Player { get; set; }
        public BallModel Ball { get; set; }
        public BaseWorldSettings WorldSettings { get; set; }
    }
}
