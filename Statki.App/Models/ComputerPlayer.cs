using Statki.Contract.Models;

namespace Statki.App.Models
{
    public class ComputerPlayer : Player
    {
        public override bool HasBoard => true;

        public override bool HasMove => false;

        public override void PerformMove()
        {
            //generate a random available coordinate and shoot
        }
    }
}
