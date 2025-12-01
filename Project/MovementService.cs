namespace Project;

public class MovementService
{
    private readonly Map map;

    public MovementService(Map map)
    {
        this.map = map;
    }

    public bool TryMove(ref int x, ref int y, int dx, int dy, out IArea? destination)
    {
        int newX = x + dx;
        int newY = y + dy;

        destination = map.GetArea(newX, newY);

        if (destination == null)
        {
            return false; // Invalid movement
        }

        x = newX;
        y = newY;
        return true;
    }
}

