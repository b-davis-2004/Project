namespace Project;

public class Dryad : IEnemy
{
    public string Name => "Dryad";
    public int Health { get; set; } = 30;

    private static readonly Random random = new Random();

    public int AttackPower => random.Next(0, 11);

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
//Defining specific enemy type with its unique properties and behaviors
//Implements IEnemy interface
//Provides concrete implementations for Attack and TakeDamage methods
//Includes properties for Name, Health, AttackPower, and IsDefeated status
