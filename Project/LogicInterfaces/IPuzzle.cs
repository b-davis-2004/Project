namespace Project;

public interface IPuzzle
{
    string Name { get; }
    string Description { get; }
    
    bool Resolve(Player player);
    bool IsResolved { get; set; }
}

 //tells you what the puzzle is
 //represents a puzzle (an object)
 //will be used by PuzzleConflicts
