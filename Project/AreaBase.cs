namespace Project;

public abstract class AreaBase : IArea
{
    public abstract string Name { get; }
    public abstract string Description { get; }

    public abstract int X { get; }
    public abstract int Y { get; }

    public IConflict? Conflict { get; set; } // nullable so conflict not required for origin area

    public virtual void Enter(Player player)
    {
        Console.WriteLine($"You enter a {Name}.");
        Console.WriteLine(Description);

        if (Conflict != null && !Conflict.IsResolved)
        {
            Conflict.Resolve(player);
        }
    }
}

//Abstract Class that will minimize the repeat of area introduction method and conflict/resolution intialisation
//will run specific area classes through this abstract class, then will run this through IArea interface