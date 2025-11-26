namespace Project
{
    public class Echo : IPuzzle
    {
        public string Name => "The Valley speaks to you.";
        public string Description => "Solve the the riddle to proceed. I speak without a mouth and hear without ears. I dwell in the woods, where voices bounce off stone and tree. What am I?";

        public bool IsResolved { get; set; } = false;

        public bool Resolve(Player player)
        {
            Console.Write("Enter your answer: ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "Echo")
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