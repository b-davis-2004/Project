namespace Project;

public interface IArea
{
    string Name { get; }
    string Description { get; }

    int X { get; }
    int Y { get; }

    IConflict? Conflict { get;  }

    void Enter(Player player);
}

//Interface for areas in the game
//Defines an area with a name, description, and conflict
//Will be used by AreaBase abstract class and concrete area classes