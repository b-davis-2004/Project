namespace Project
{
    public class Forest : AreaBase
    {
        public override string Name => "Forest";
        public override string Description => "This is the dark and eerie forest, filled with towering trees and the sounds of unknown creatures.";

        public Forest()
        {
            Conflict = new CombatConflict(new Dryad());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}