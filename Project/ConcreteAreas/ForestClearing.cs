namespace Project
{
    public class ForestClearing : AreaBase
    {
        public override string Name => "Forest Clearing";
        public override string Description => "This is the edge of the forest. Dense trees give way to sunlight and things seem calmer now.";

        public override int X => -1;
        public override int Y =>  -1;
        
        public ForestClearing()
        {
            Conflict = new PuzzleConflict(new Clock());
        }
    }



    //concrete area class - specific area for name, description, and assigning its conflict
}