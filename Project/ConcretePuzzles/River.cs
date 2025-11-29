namespace Project
{
    public class River : IPuzzle
    {
        public string Name => "Whispering Wind";
        public string Description => "\nSolve the the riddle whispered on the wind to proceed. \nWhat runs but never walks, has a mouth but never talks, \nhas a bed but never sleeps?";

        public bool IsResolved { get; set; } = false;

        public bool Resolve(Player player)
        {
            Console.Write("Enter your answer: ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "river")
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