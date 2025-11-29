namespace Project
{
    public class Clock : IPuzzle
    {
        public string Name => "Ancient Riddle";
        public string Description => "\nSolve the ancient riddle to proceed. \nWhat has hands but cannot clap?";

        public bool IsResolved { get; set; } = false;

        public bool Resolve(Player player)
        {
            Console.Write("Enter your answer: ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "clock")
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