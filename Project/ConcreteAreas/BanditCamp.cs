namespace Project
{
    public class BanditCamp : AreaBase
    {
        public override string Name => "Bandit Camp";
        public override string Description => "This is the notorious bandit camp, filled with dangerous outlaws and hidden traps.";

        public BanditCamp()
        {
            Conflict = new CombatConflict(new BanditLeader());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
    //will need to rename according to what the area will be called
}