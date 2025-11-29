namespace Project;

public interface IConflict
{
    string Description { get; }
    void Resolve(Player player);
    bool IsResolved { get; }
}


//Interface for event or situation the player must resolve (a process)
//How the game react to the counter - e.g. you must fight, solve a riddle, etc.
//encapsulation