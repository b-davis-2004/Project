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
            // handle death
        }
    }
}

