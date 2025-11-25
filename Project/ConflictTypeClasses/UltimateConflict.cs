using Project;

public class UltimateConflict : IConflict
{
    public string Description => $"You encounter a hostile {Ultimate.Name}!";
    public bool IsResolved { get; private set; }
    public IUltimate Ultimate { get; private set; }

    public UltimateConflict(IUltimate ultimate)
    {
        Ultimate = ultimate;
        IsResolved = false;
    }

    public void Resolve(Player player)
    {
        Console.WriteLine(Description);

        // Puzzle step
        if (!Ultimate.IsResolved)
        {
            Console.WriteLine("Before combat begins, you must solve the puzzle...");
            Ultimate.Resolve(player);
        }

        // Combat loop
        while (!Ultimate.IsDefeated && player.Health > 0)
        {
            Console.WriteLine("Do you want to Attack (A) or Run (R)?");
            var input = Console.ReadLine()?.ToUpper();

            if (input == "A")
            {
                Ultimate.TakeDamage(player.AttackPower);

                if (!Ultimate.IsDefeated)
                {
                    Ultimate.Attack(player);
                }
            }
            else if (input == "R")
            {
                Console.WriteLine("You run away!");
                 player.Health -= 30;//penalty for running away
                Console.WriteLine($"You exhausted yourself while running. Your health is now {player.Health}.");
                return;
            }
        }

        // End conditions
        if (Ultimate.IsDefeated)
        {
            Console.WriteLine($"You have defeated the {Ultimate.Name}!");
            Console.WriteLine("The darkness fades... You are victorious!");
            IsResolved = true;
            Environment.Exit(0);
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have been defeated...");
            Console.WriteLine("Game Over.");
            Environment.Exit(0);
        }
    }
}
