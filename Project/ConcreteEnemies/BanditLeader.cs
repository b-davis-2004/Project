namespace Project;

public class BanditLeader : IEnemy
{
    public string Name => "Bandit Leader";
    public int Health { get; set; } = 25;
    public int AttackPower => 5;

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
