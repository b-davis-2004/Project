namespace Project;

public class PuzzleConflict : IConflict
{
    public string Description => $"You are face with a(n) {Puzzle.Name}!";
    public bool IsResolved { get; private set; }
    public IPuzzle Puzzle { get; private set; }

    public PuzzleConflict(IPuzzle puzzle)
    {
        Puzzle = puzzle;
        IsResolved = false;
    }

    public void Resolve(Player player)
    {
        Console.WriteLine(Description);
        while (!IsResolved)
        {
            if (Puzzle.Resolve(player))
            {
                IsResolved = true;
            }
        }
    }
}


// conflict type class for puzzle conflicts
// will need to add the conflict logic that inplments concrete puzzle classes
// to be used by concrete area classes
// very similar logic to CombatConflict class