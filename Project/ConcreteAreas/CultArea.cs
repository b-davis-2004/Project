namespace Project
{
    public class CultArea : AreaBase
    {
        public override string Name => "Cult Area";
        public override string Description => "xyz";

        public override int X => 1;
        public override int Y =>  2;
        
        public CultArea()
        {
            Conflict = new CombatConflict(new Cultist());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}