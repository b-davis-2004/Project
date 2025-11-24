namespace Project;

public class Map
{
    private readonly IArea[,] grid;

    public Map(int width, int height)
    {
        grid = new IArea[width, height];
    }

    public void AddArea(IArea area)
    {
        grid[area.X, area.Y] = area;
    }

    public IArea? GetArea(int x, int y)
    {
        var area = grid[x, y];
        if (area == null)
        {
            Console.WriteLine("This is uncharted territory. Try a different direction.");
        }
        return area;
    }
}
//Map class to hold areas in a grid layout
//Allows adding and retrieving areas based on coordinates