namespace Project;

public class Map
{
    //creating grid for coordinate movement system
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

    //out of bounds error handling for coordinate movement
    public IArea? GetArea(int x, int y)
    {
        int xIndex = x + 1;
        int yIndex = y + 1;

        if (!IsInBounds(xIndex, yIndex))
        {
            Console.WriteLine("This is uncharted territory. Try a different direction..");
            return null;
        }

        var area = grid[xIndex, yIndex];
        if (area == null){}
        return area;
    }

    private bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < grid.GetLength(0) &&
               y >= 0 && y < grid.GetLength(1);
    }
}

//Map class to hold areas in a grid layout
//Allows adding and retrieving areas based on coordinates