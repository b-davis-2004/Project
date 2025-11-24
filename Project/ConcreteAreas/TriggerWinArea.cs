
using Project.ConcreteUltimates;

namespace Project
{
    public class TriggerWinArea : AreaBase
    {
        public override string Name => "Something else";
        public override string Description => "This is the boss area.";

        public TriggerWinArea()
        {
            Conflict = new UltimateConflict(new Ultimate());
        }
    }
}


    //area designated to win the game - may contain ultimate conflict for simplicity
    //"boss level"