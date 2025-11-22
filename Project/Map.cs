namespace Project;

public class Map
{
    private readonly Dictionary<(int x, int y), IArea> _areas = new();

    public void AddArea(int x, int y, IArea area)
    {
        _areas[(x, y)] = area;
    }

    public IArea? GetArea(int x, int y)
    {
        _areas.TryGetValue((x, y), out var area);
        return area;
    }

}

