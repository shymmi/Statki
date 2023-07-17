namespace Statki.Contract.Models
{
    public abstract class Player
    {
        public abstract bool HasBoard { get; }
        public abstract bool HasMove { get; }
        public Board Board { get; set; }

        public abstract void PerformMove();
    }
}
