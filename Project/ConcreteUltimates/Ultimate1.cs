namespace Project;

public class Ultimate1 : IUltimate
{
    public string Description => "A Wraith has appeared, a powerful foe - draining life and chilling the soul." +
        "It's growling presence fills the air with dread, and its eyes burn with an otherworldly fire." + "It does not attack yet." + "Instead, it challenges you to solve a riddle: " +
        "I’m light as a feather, yet the strongest person can’t hold me for much more than a minute.?";
    public bool IsResolved { get; set; } = false;

    public bool Resolve(Player player)
    {
        Console.Write("Enter your answer: ");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (answer == "Breath")
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

        Console.WriteLine("Incorrect answer. Try again.");
        player.Health -= 5; // Penalty for wrong answer
        return false;
    }
    public string Name => "Wraith";
    public int Health { get; set; } = 50;
    public int AttackPower => 15;

    public bool IsDefeated => Health <= 0;

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