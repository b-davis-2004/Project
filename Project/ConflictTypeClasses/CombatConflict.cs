namespace Project;

public class CombatConflict : IConflict
{
    public string Description => $"You encounter a hostile {Enemy.Name}!";
    public bool IsResolved { get; private set; }
    public IEnemy Enemy { get; private set; }

    public CombatConflict(IEnemy enemy)
    {
        Enemy = enemy;
        IsResolved = false;
    }

    public void Resolve(Player player)
    {
        Console.WriteLine(Description);
        while (!Enemy.IsDefeated && player.Health > 0)
        {
            Console.WriteLine("Do you want to Attack (A) or Run (R)?");
            var input = Console.ReadLine()?.ToUpper();

            if (input == "A")
            {
                Enemy.TakeDamage(player.AttackPower);
                if (!Enemy.IsDefeated)
                {
                    Enemy.Attack(player);
                }
            }
            else if (input == "R")
            {
                Console.WriteLine("You run away!");
                player.Health -= 5; //penalty for running away
                Console.WriteLine($"You exhausted yourself while running. Your health is now {player.Health}.");
                return;
            }
        }

        if (Enemy.IsDefeated)
        {
            Console.WriteLine($"You have defeated the {Enemy.Name}!");
            IsResolved = true;
        }

        if (player.Health <= 0)
        {
            Console.WriteLine("You have been defeated...");
            Console.WriteLine("Game Over.");
            Environment.Exit(0); // Exit the game if player dies
            // handle death
        }
    }
}

