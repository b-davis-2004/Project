
namespace Project
{
    public class MountainPass : AreaBase
    {
        public override string Name => "Mountain Pass";
        public override string Description => "This is the treacherous mountain pass, with steep cliffs and howling winds.";

        public override int X => 2;
        public override int Y =>  0;
        
        public MountainPass()
        {
            Conflict = new PuzzleConflict(new River());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}