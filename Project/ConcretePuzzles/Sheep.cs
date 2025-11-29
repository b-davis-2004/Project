namespace Project
{
    public class Sheep : IPuzzle
    {
        public string Name => "Mumbling Meadow";
        public string Description => "\nSolve the the riddle mumbled by the meadow to proceed. \nA shepherd had 17 sheep. \nAll but nine perished in the storm. \nHow many remain?";

        public bool IsResolved { get; set; } = false;

        public bool Resolve(Player player)
        {
            Console.Write("Enter your answer: ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "nine")
            {
                IsResolved = true;
                Console.WriteLine("Correct! You have solved the puzzle.");
                player.Health += 5; // Reward player with health
                Console.WriteLine($"Your health is now: {player.Health}");
                return true;
            }

            Console.WriteLine("Incorrect answer. Try again.");
            return false;
        }
    }
}


// Concrete puzzle class implementing IPuzzle interface
// Represents a specific puzzle with its own properties and solving logic
// Includes properties for Name, Description, and IsResolved status