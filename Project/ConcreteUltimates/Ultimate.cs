using System;

namespace Project.ConcreteUltimates;

public class Ultimate : IEnemy
{
    public string Name => "Ultimate Foe";
    public int Health { get; set; } = 30;
    public int AttackPower => 10;

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