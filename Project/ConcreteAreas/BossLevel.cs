
namespace Project
{
    public class BossLevel : AreaBase
    {
        public override string Name => "Something else";
        public override string Description => "This is the boss area.";
        
        public override int X => 3;
        public override int Y => 3;

        public BossLevel()
        {
            Conflict = new UltimateConflict(new Boss());
        }
    }
}


    //area designated to win the game - may contain ultimate conflict for simplicity
    //"boss level"