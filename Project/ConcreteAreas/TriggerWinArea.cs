
namespace Project
{
    public class TriggerWinArea : AreaBase
    {
        public override string Name => "Something else";
        public override string Description => "This is the boss area.";
        
        public override int X => 3;
        public override int Y => 3;

        public TriggerWinArea()
        {
            Conflict = new UltimateConflict(new Boss());
        }
    }
}


    //area designated to win the game - may contain ultimate conflict for simplicity
    //"boss level"