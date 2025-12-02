namespace Project;

public class Boss : IUltimate
{
    //puzzle logic half of the ultimate
    public string Description =>
        $"{Name} has appeared — a powerful foe draining life and chilling the soul.\n" +
        "Its growling presence fills the air with dread, eyes burning with otherworldly fire.\n" +
        "It does not attack yet. Instead, it challenges you with a riddle:\n" +
        "I’m light as a feather, yet the strongest person can’t hold me for much more than a minute.";

    public bool IsResolved { get; set; } = false;

    public bool Resolve(Player player)
    {
        Console.Write("Enter your answer: ");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "breath")
        {
            IsResolved = true;
            Console.WriteLine("Correct! You have solved the puzzle.");
            player.Health += 5; // Reward player with health
            player.AttackPower += 10; // Reward player with increased attack power
            Console.WriteLine($"Your health is now: {player.Health}");
            Console.WriteLine($"Your attack power is icnreased by 10!"); 
            Console.WriteLine("The Wraith is angered by your success, and attacks - intending to steal YOUR breath!");
            return true;
        }

            Console.WriteLine("\n Incorrect answer. The Wraith drains some of your strength.");
            player.Health -= 5;
            Console.WriteLine($"Your health is now {player.Health}.");
            return false;

    }

    // Combat logic half of the ultimate
    public string Name => "Wraith";
    public int Health { get; set; } = 50;

    private static readonly Random random = new Random();

    public int AttackPower => random.Next(4, 21);

    public bool IsDefeated => Health <= 0;

    //handles enemy attack
    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!");
        player.Health -= AttackPower;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage!");
    }


}


//concrete ultimates conflict that will be both puzzle and enemy
// currently using enemy implementation only