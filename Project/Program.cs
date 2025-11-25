using Project;


Player player = new Player();
Map world = new Map(3, 3);

// Define map layout
// Uses Concreate Area and Conflict implementations

world.AddArea(new Forest());
world.AddArea(new BanditCamp());
world.AddArea(new TriggerWinArea());
world.AddArea(new OriginPoint());
world.AddArea(new MountainPass());


Console.WriteLine("Welcome, adventurer!");
Console.WriteLine("Use N/W/S/E to move North, West, South, or East. Type 'QUIT' to exit.\n");

while (player.Health > 0)
{
    var currentArea = world.GetArea(player.X, player.Y);
    if (currentArea != null)
    {
        currentArea.Enter(player);
    }
    
    //handles player death
    if (player.Health <= 0)
    {
        Console.WriteLine("You have fallen in battle. Game Over.");
        break;
    }

    Console.Write("\nWhere do you want to go (N/W/S/E)? ");
    string? input = Console.ReadLine()?.Trim().ToUpper();

    if (input == "QUIT") break;

    switch (input)
    {
        case "N": player.Y += 1; break;
        case "W": player.Y -= 1; break;
        case "S": player.X -= 1; break;
        case "E": player.X += 1; break;
        default:
            Console.WriteLine("Invalid command. Use N/W/S/E or 'QUIT'.");
            break;
    }

    Console.WriteLine($"Your current health: {player.Health}");
}

Console.WriteLine("\nThanks for playing!");
// Main game loop handling player movement and area interactions
// Initializes player and world map