using Project;


Player player = new Player();
Map world = new Map(3, 3);

// Define map layout
// Uses Concreate Area and Conflict implementations

world.AddArea(new Forest());
world.AddArea(new BanditCamp());
world.AddArea(new BossLevel());
world.AddArea(new OriginPoint());
world.AddArea(new MountainPass());
world.AddArea(new CultArea());
world.AddArea(new Meadow());


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

    // prompts user choice for movement
    Console.Write("\nWhere do you want to go (N/W/S/E)? ");
    string? input = Console.ReadLine()?.Trim().ToUpper();

    if (input == "QUIT") break;

    // Compute intended movement
    int newX = player.X;
    int newY = player.Y;

    switch (input)
    {
        case "N": newY += 1; break;
        case "S": newY -= 1; break;
        case "E": newX += 1; break;
        case "W": newX -= 1; break;
        default:
            Console.WriteLine("Invalid command. Use N/W/S/E or 'QUIT'.");
            continue;
    }

    // Ask the map if the move is valid BEFORE applying it
    var destination = world.GetArea(newX, newY);

    if (destination == null)
    {
        Console.WriteLine("You cannot move that way. Choose another direction.");
        continue;
    }

    // Move is valid → update coordinates
    player.X = newX;
    player.Y = newY;

    Console.WriteLine($"You travel {input}.");
    Console.WriteLine($"Your current health: {player.Health}");
}

Console.WriteLine("\nThanks for playing!");
// Main game loop handling player movement and area interactions
// Initializes player and world map