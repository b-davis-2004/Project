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
        int xIndex = area.X + 1; // shift -1..1 → 0..2
        int yIndex = area.Y + 1;

        grid[xIndex, yIndex] = area;
    }

    public IArea? GetArea(int x, int y)
    {
        int xIndex = x + 1;
        int yIndex = y + 1;

        var area = grid[xIndex, yIndex];
        if (area == null)
        {
            Console.WriteLine("This is uncharted territory. Try a different direction.");
        }
        return area;
    }
}
//Map class to hold areas in a grid layout
//Allows adding and retrieving areas based on coordinates