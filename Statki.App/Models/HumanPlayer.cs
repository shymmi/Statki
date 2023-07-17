using Statki.Contract.Models;

namespace Statki.App.Models
{
    public class HumanPlayer : Player
    {
        public override bool HasBoard => false;
        public override bool HasMove => true;

        public override void PerformMove()
        {
            //read coordinates from the console
            //send shotFired event
        }
    }
}
