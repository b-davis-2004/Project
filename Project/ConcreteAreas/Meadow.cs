
namespace Project
{
    public class Meadow : AreaBase
    {
        public override string Name => "Valley Plain";
        public override string Description => "This is the valley of the mountain.";

        public override int X => -1;
        public override int Y => 1;
        
        public Meadow()
        {
            Conflict = new PuzzleConflict(new xyz());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}