
namespace Project
{
    public class Meadow : AreaBase
    {
        public override string Name => "Grassy Meadow";
        public override string Description => "This is a peaceful, unassuming grassy meadow. Take your time to smell the flowers.";

        public override int X => 1;
        public override int Y => 0;
        
        public Meadow()
        {
            Conflict = new PuzzleConflict(new Sheep());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}