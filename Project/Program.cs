using Project;

Player player = new Player();
Map world = new Map();

// Define map layout
// Uses Concreate Area and Conflict implementations
//Might be better to define coordinates outside of main program
world.AddArea(0, 0, new Forest{ Conflict = new CombatConflict(new Dryad()) });
world.AddArea(1, 0, new BanditCamp { Conflict = new CombatConflict(new BanditLeader()) });    // East +1
world.AddArea(2, 0, new MountainPass { Conflict = new PuzzleConflict(new Puzzle1()) }); // East +2

Console.WriteLine("Welcome, adventurer!");
Console.WriteLine("Use N/W/S/E to move North, West, South, or East. Type 'QUIT' to exit.\n");

while (player.Health > 0)
{
    //world.DescribeLocation(player); - was duplicating area description

    var currentArea = world.GetArea(player.X, player.Y);
    if (currentArea != null)
    {
        currentArea.Enter(player);
    }

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