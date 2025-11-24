namespace Project;

public class Map
{
    private readonly Dictionary<(int x, int y), IArea> _areas = new();

    private IArea[,] grid;

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
        _areas.TryGetValue((x, y), out var area);
        if (area == null)
        {
            Console.WriteLine("This is uncharted territory. Try a different direction.");
        }
        return area;
    }

}


