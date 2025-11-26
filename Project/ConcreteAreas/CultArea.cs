namespace Project
{
    public class CultArea : AreaBase
    {
        public override string Name => "Cult Area";
        public override string Description => "You stumble upon a cermony... It fills you with dread as you watch the group murmur in languages unknown to man to an alter.";

        public override int X => 1;
        public override int Y =>  2;
        
        public CultArea()
        {
            Conflict = new CombatConflict(new Cultist());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}